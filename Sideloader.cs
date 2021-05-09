﻿using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using System.Net;
using System.Windows.Forms;
using JR.Utils.GUI.Forms;

namespace AndroidSideloader
{
    class Sideloader
    {
        public static string TempFolder = Path.Combine(Environment.CurrentDirectory, "temp");
        public static string CrashLogPath = "crashlog.txt";

        public static string SpooferWarning = @"Please make sure you have installed:
- APKTool
- Java JDK
- aapt
And all of them added to PATH, without ANY of them, the spoofer won't work!";

        //push user.json to device (required for some devices like oculus quest)
        public static void PushUserJsons()
        {
            ADB.WakeDevice();
            foreach (var userJson in UsernameForm.userJsons)
            {
                UsernameForm.createUserJsonByName(Utilities.GeneralUtilities.randomString(16), userJson);
                ADB.RunAdbCommandToString("push \"" + Environment.CurrentDirectory + $"\\{userJson}\" " + " /sdcard/");
                File.Delete(userJson);
            }
        }

        //List of all installed package names from connected device
        public static List<string> InstalledPackageNames = new List<string>();

        //Remove folder from device
        public static ProcessOutput RemoveFolder(string path)
        {
            ADB.WakeDevice();
            return ADB.RunAdbCommandToString($"shell rm -r {path}");
        }

        //For games that require manual install, like having another folder that isnt an obb

        //TOFIX
        public static ProcessOutput RunADBCommandsFromFile(string path, string RunFromPath)
        {
            ADB.WakeDevice();
            ProcessOutput output = new ProcessOutput();
            var commands = File.ReadAllLines(path);
            foreach (string cmd in commands)
            {
                if (cmd.StartsWith("adb"))
                {
                    var regex = new Regex(Regex.Escape("adb"));
                    var command = regex.Replace("adb", $"\"{ADB.adbFilePath}\"", 1);

                    Logger.Log($"Logging command: {command} from file: {path}");

                    if (ADB.DeviceID.Length > 1)
                        command = $" -s {ADB.DeviceID} {command}";
                    output += Utilities.GeneralUtilities.startProcess("cmd.exe", RunFromPath, command);
                }
            }
            return output;
        }

        //Recursive sideload any apk file
        public static ProcessOutput RecursiveOutput = new ProcessOutput();
        public static void RecursiveSideload(string FolderPath)
        {
            try
            {
                foreach (string f in Directory.GetFiles(FolderPath))
                {
                    if (Path.GetExtension(f)==".apk")
                        RecursiveOutput += ADB.Sideload(f);
                }

                foreach (string d in Directory.GetDirectories(FolderPath))
                {
                    RecursiveSideload(d);
                }
            }
            catch (Exception ex) { Logger.Log(ex.Message); }
        }

        //Recursive copy any obb folder
        public static void RecursiveCopyOBB(string FolderPath)
        {
            try
            {
                foreach (string f in Directory.GetFiles(FolderPath))
                {
                    RecursiveOutput += ADB.CopyOBB(f);
                }

                foreach (string d in Directory.GetDirectories(FolderPath))
                {
                    RecursiveCopyOBB(d);
                }
            }
            catch (Exception ex) { Logger.Log(ex.Message); }
        }

        //uninstalls an app
        public static ProcessOutput UninstallGame(string GameName)
        {
            ADB.WakeDevice();
            ProcessOutput output = new ProcessOutput("", "");

            string packageName = Sideloader.gameNameToPackageName(GameName);

            DialogResult dialogResult = FlexibleMessageBox.Show($"Are you sure you want to uninstall {packageName}? this CANNOT be undone!", "WARNING!", MessageBoxButtons.YesNo);
            if (dialogResult != DialogResult.Yes)
                return output;

            output = ADB.UninstallPackage(packageName);

            //remove both data and obb if there is any
            Sideloader.RemoveFolder("/sdcard/Android/obb/" + packageName);
            Sideloader.RemoveFolder("/sdcard/Android/data/" + packageName);

            return output;
        }

        //Extracts apk from device, saves it by package name to sideloader folder
        public static ProcessOutput getApk(string GameName)
        {
            ADB.WakeDevice();
            ProcessOutput output = new ProcessOutput("", "");

            string packageName = Sideloader.gameNameToPackageName(GameName);

            output = ADB.RunAdbCommandToString("shell pm path " + packageName);

            string apkPath = output.Output; //Get apk

            apkPath = apkPath.Remove(apkPath.Length - 1);
            apkPath = apkPath.Remove(0, 8); //remove package:
            apkPath = apkPath.Remove(apkPath.Length - 1);

            output += ADB.RunAdbCommandToString("pull " + apkPath); //pull apk

            string currApkPath = apkPath;
            while (currApkPath.Contains("/"))
                currApkPath = currApkPath.Substring(currApkPath.IndexOf("/") + 1);

            if (File.Exists(Environment.CurrentDirectory + "\\" + packageName + ".apk"))
                File.Delete(Environment.CurrentDirectory + "\\" + packageName + ".apk");

            File.Move(Environment.CurrentDirectory + "\\adb\\" + currApkPath, Environment.CurrentDirectory + "\\" + packageName + ".apk");

            return output;
        }

        public static string gameNameToPackageName(string gameName)
        {
            foreach (string[] game in SideloaderRCLONE.games)
            {
                if (gameName.Equals(game[SideloaderRCLONE.GameNameIndex]))
                    return game[SideloaderRCLONE.PackageNameIndex];
            }
            return gameName;
        }

        //Downloads the required files
        public static void downloadFiles()
        {
            var client = new WebClient();
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            try
            {
                if (!File.Exists("Sideloader Launcher.exe"))
                    client.DownloadFile("https://github.com/nerdunit/androidsideloader/raw/master/Sideloader%20Launcher.exe", "Sideloader Launcher.exe");

                if (!Directory.Exists(ADB.adbFolderPath)) //if there is no adb folder, download and extract
                {
                    client.DownloadFile("https://github.com/nerdunit/androidsideloader/raw/master/adb.7z", "adb.7z");
                    Utilities.Zip.ExtractFile(Environment.CurrentDirectory + "\\adb.7z", Environment.CurrentDirectory);
                    File.Delete("adb.7z");
                }

                if (!Directory.Exists(Environment.CurrentDirectory + "\\rclone"))
                {
                    string url;
                    if (Environment.Is64BitOperatingSystem)
                        url = "https://downloads.rclone.org/v1.55.1/rclone-v1.55.1-windows-amd64.zip";
                    else
                        url = "https://downloads.rclone.org/v1.55.1/rclone-v1.55.1-windows-386.zip";
                    //Since sideloader is build for x86, it should work on both x86 and x64 so we download the according rclone version

                    client.DownloadFile(url, "rclone.zip");

                    Utilities.Zip.ExtractFile(Environment.CurrentDirectory + "\\rclone.zip", Environment.CurrentDirectory);

                    File.Delete("rclone.zip");

                    string[] folders = Directory.GetDirectories(Environment.CurrentDirectory);
                    foreach (string folder in folders)
                    {
                        if (folder.Contains("rclone"))
                        {
                            Directory.Move(folder, "rclone");
                            break; //only 1 rclone folder
                        }
                    }
                }

            }
            catch
            {
                FlexibleMessageBox.Show("Your internet is not working properly or rclone/github servers are down, some files may be missing (adb, rclone or launcher)");
            }
        }
    }

    
}
