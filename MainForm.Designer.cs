﻿namespace AndroidSideloader
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.m_combo = new SergeUtils.EasyCompletionComboBox();
            this.startsideloadbutton = new System.Windows.Forms.Button();
            this.devicesbutton = new System.Windows.Forms.Button();
            this.obbcopybutton = new System.Windows.Forms.Button();
            this.backupbutton = new System.Windows.Forms.Button();
            this.restorebutton = new System.Windows.Forms.Button();
            this.getApkButton = new System.Windows.Forms.Button();
            this.uninstallAppButton = new System.Windows.Forms.Button();
            this.sideloadFolderButton = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.copyBulkObbButton = new System.Windows.Forms.Button();
            this.downloadInstallGameButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.downloadingLabel = new System.Windows.Forms.Label();
            this.aboutBtn = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.otherContainer = new System.Windows.Forms.Panel();
            this.InstallQUset = new System.Windows.Forms.Button();
            this.removeQUSetting = new System.Windows.Forms.Button();
            this.ThemeChangerButton = new System.Windows.Forms.Button();
            this.QuestOptionsButton = new System.Windows.Forms.Button();
            this.ADBWirelessDisable = new System.Windows.Forms.Button();
            this.ADBWirelessEnable = new System.Windows.Forms.Button();
            this.otherDrop = new System.Windows.Forms.Button();
            this.backupContainer = new System.Windows.Forms.Panel();
            this.backupDrop = new System.Windows.Forms.Button();
            this.sideloadContainer = new System.Windows.Forms.Panel();
            this.UpdateGamesButton = new System.Windows.Forms.Button();
            this.listApkButton = new System.Windows.Forms.Button();
            this.sideloadDrop = new System.Windows.Forms.Button();
            this.diskLabel = new System.Windows.Forms.Label();
            this.speedLabel = new System.Windows.Forms.Label();
            this.etaLabel = new System.Windows.Forms.Label();
            this.freeDisclaimer = new System.Windows.Forms.Label();
            this.gamesQueListBox = new System.Windows.Forms.ListBox();
            this.devicesComboBox = new System.Windows.Forms.ComboBox();
            this.remotesList = new System.Windows.Forms.ComboBox();
            this.gamesListView = new System.Windows.Forms.ListView();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.gamesQueueLabel = new System.Windows.Forms.Label();
            this.MountButton = new System.Windows.Forms.Button();
            this.ProgressText = new System.Windows.Forms.Label();
            this.notesRichTextBox = new System.Windows.Forms.RichTextBox();
            this.DragDropLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gamesPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.EnterInstallBox = new System.Windows.Forms.CheckBox();
            this.ADBcommandbox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.otherContainer.SuspendLayout();
            this.backupContainer.SuspendLayout();
            this.sideloadContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // m_combo
            // 
            this.m_combo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.m_combo.BackColor = global::AndroidSideloader.Properties.Settings.Default.ComboBoxColor;
            this.m_combo.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "ComboBoxColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.m_combo.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.m_combo.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.m_combo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_combo.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.m_combo.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.m_combo.Location = new System.Drawing.Point(303, 10);
            this.m_combo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m_combo.Name = "m_combo";
            this.m_combo.Size = new System.Drawing.Size(469, 33);
            this.m_combo.TabIndex = 0;
            this.m_combo.Text = "Select an app to uninstall...";
            // 
            // startsideloadbutton
            // 
            this.startsideloadbutton.BackColor = global::AndroidSideloader.Properties.Settings.Default.SubButtonColor;
            this.startsideloadbutton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.startsideloadbutton.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.startsideloadbutton.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "SubButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.startsideloadbutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.startsideloadbutton.FlatAppearance.BorderSize = 0;
            this.startsideloadbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startsideloadbutton.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.startsideloadbutton.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.startsideloadbutton.Location = new System.Drawing.Point(0, 170);
            this.startsideloadbutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.startsideloadbutton.Name = "startsideloadbutton";
            this.startsideloadbutton.Padding = new System.Windows.Forms.Padding(31, 0, 0, 0);
            this.startsideloadbutton.Size = new System.Drawing.Size(291, 34);
            this.startsideloadbutton.TabIndex = 5;
            this.startsideloadbutton.Text = "Sideload APK";
            this.startsideloadbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.startsideloadbutton.UseVisualStyleBackColor = false;
            this.startsideloadbutton.Click += new System.EventHandler(this.startsideloadbutton_Click);
            // 
            // devicesbutton
            // 
            this.devicesbutton.BackColor = global::AndroidSideloader.Properties.Settings.Default.ButtonColor;
            this.devicesbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.devicesbutton.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "ButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.devicesbutton.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.devicesbutton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.devicesbutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.devicesbutton.FlatAppearance.BorderSize = 0;
            this.devicesbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.devicesbutton.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.devicesbutton.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.devicesbutton.Location = new System.Drawing.Point(0, 0);
            this.devicesbutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.devicesbutton.Name = "devicesbutton";
            this.devicesbutton.Size = new System.Drawing.Size(291, 34);
            this.devicesbutton.TabIndex = 0;
            this.devicesbutton.Text = "RECONNECT DEVICE";
            this.devicesbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.devicesbutton.UseVisualStyleBackColor = false;
            this.devicesbutton.Click += new System.EventHandler(this.devicesbutton_Click);
            // 
            // obbcopybutton
            // 
            this.obbcopybutton.BackColor = global::AndroidSideloader.Properties.Settings.Default.SubButtonColor;
            this.obbcopybutton.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.obbcopybutton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.obbcopybutton.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "SubButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.obbcopybutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.obbcopybutton.FlatAppearance.BorderSize = 0;
            this.obbcopybutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.obbcopybutton.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.obbcopybutton.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.obbcopybutton.Location = new System.Drawing.Point(0, 0);
            this.obbcopybutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.obbcopybutton.Name = "obbcopybutton";
            this.obbcopybutton.Padding = new System.Windows.Forms.Padding(31, 0, 0, 0);
            this.obbcopybutton.Size = new System.Drawing.Size(291, 34);
            this.obbcopybutton.TabIndex = 0;
            this.obbcopybutton.Text = "Copy OBB";
            this.obbcopybutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.obbcopybutton.UseVisualStyleBackColor = false;
            this.obbcopybutton.Click += new System.EventHandler(this.obbcopybutton_Click);
            // 
            // backupbutton
            // 
            this.backupbutton.BackColor = global::AndroidSideloader.Properties.Settings.Default.SubButtonColor;
            this.backupbutton.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "SubButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.backupbutton.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.backupbutton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.backupbutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.backupbutton.FlatAppearance.BorderSize = 0;
            this.backupbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backupbutton.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.backupbutton.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.backupbutton.Location = new System.Drawing.Point(0, 34);
            this.backupbutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.backupbutton.Name = "backupbutton";
            this.backupbutton.Padding = new System.Windows.Forms.Padding(31, 0, 0, 0);
            this.backupbutton.Size = new System.Drawing.Size(291, 34);
            this.backupbutton.TabIndex = 1;
            this.backupbutton.Text = "Backup Gamedata";
            this.backupbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backupbutton.UseVisualStyleBackColor = false;
            this.backupbutton.Click += new System.EventHandler(this.backupbutton_Click);
            // 
            // restorebutton
            // 
            this.restorebutton.BackColor = global::AndroidSideloader.Properties.Settings.Default.SubButtonColor;
            this.restorebutton.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.restorebutton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.restorebutton.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "SubButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.restorebutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.restorebutton.FlatAppearance.BorderSize = 0;
            this.restorebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restorebutton.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.restorebutton.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.restorebutton.Location = new System.Drawing.Point(0, 0);
            this.restorebutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.restorebutton.Name = "restorebutton";
            this.restorebutton.Padding = new System.Windows.Forms.Padding(31, 0, 0, 0);
            this.restorebutton.Size = new System.Drawing.Size(291, 34);
            this.restorebutton.TabIndex = 0;
            this.restorebutton.Text = "Restore Gamedata";
            this.restorebutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.restorebutton.UseVisualStyleBackColor = false;
            this.restorebutton.Click += new System.EventHandler(this.restorebutton_Click);
            // 
            // getApkButton
            // 
            this.getApkButton.BackColor = global::AndroidSideloader.Properties.Settings.Default.SubButtonColor;
            this.getApkButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.getApkButton.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.getApkButton.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "SubButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.getApkButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.getApkButton.FlatAppearance.BorderSize = 0;
            this.getApkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getApkButton.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.getApkButton.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.getApkButton.Location = new System.Drawing.Point(0, 68);
            this.getApkButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.getApkButton.Name = "getApkButton";
            this.getApkButton.Padding = new System.Windows.Forms.Padding(31, 0, 0, 0);
            this.getApkButton.Size = new System.Drawing.Size(291, 34);
            this.getApkButton.TabIndex = 2;
            this.getApkButton.Text = "Extract Apk from device";
            this.getApkButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.getApkButton.UseVisualStyleBackColor = false;
            this.getApkButton.Click += new System.EventHandler(this.getApkButton_Click);
            // 
            // uninstallAppButton
            // 
            this.uninstallAppButton.BackColor = global::AndroidSideloader.Properties.Settings.Default.SubButtonColor;
            this.uninstallAppButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.uninstallAppButton.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.uninstallAppButton.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "SubButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.uninstallAppButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.uninstallAppButton.FlatAppearance.BorderSize = 0;
            this.uninstallAppButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uninstallAppButton.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.uninstallAppButton.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.uninstallAppButton.Location = new System.Drawing.Point(0, 102);
            this.uninstallAppButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uninstallAppButton.Name = "uninstallAppButton";
            this.uninstallAppButton.Padding = new System.Windows.Forms.Padding(31, 0, 0, 0);
            this.uninstallAppButton.Size = new System.Drawing.Size(291, 34);
            this.uninstallAppButton.TabIndex = 3;
            this.uninstallAppButton.Text = "Uninstall Selected App";
            this.uninstallAppButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uninstallAppButton.UseVisualStyleBackColor = false;
            this.uninstallAppButton.Click += new System.EventHandler(this.uninstallAppButton_Click);
            // 
            // sideloadFolderButton
            // 
            this.sideloadFolderButton.BackColor = global::AndroidSideloader.Properties.Settings.Default.SubButtonColor;
            this.sideloadFolderButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.sideloadFolderButton.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.sideloadFolderButton.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "SubButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.sideloadFolderButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.sideloadFolderButton.FlatAppearance.BorderSize = 0;
            this.sideloadFolderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sideloadFolderButton.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.sideloadFolderButton.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.sideloadFolderButton.Location = new System.Drawing.Point(0, 136);
            this.sideloadFolderButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sideloadFolderButton.Name = "sideloadFolderButton";
            this.sideloadFolderButton.Padding = new System.Windows.Forms.Padding(31, 0, 0, 0);
            this.sideloadFolderButton.Size = new System.Drawing.Size(291, 34);
            this.sideloadFolderButton.TabIndex = 4;
            this.sideloadFolderButton.Text = "Sideload Folder (recursive)";
            this.sideloadFolderButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sideloadFolderButton.UseVisualStyleBackColor = false;
            this.sideloadFolderButton.Click += new System.EventHandler(this.sideloadFolderButton_Click);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.progressBar.ForeColor = System.Drawing.Color.Purple;
            this.progressBar.Location = new System.Drawing.Point(304, 543);
            this.progressBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(489, 31);
            this.progressBar.TabIndex = 7;
            // 
            // copyBulkObbButton
            // 
            this.copyBulkObbButton.BackColor = global::AndroidSideloader.Properties.Settings.Default.SubButtonColor;
            this.copyBulkObbButton.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "SubButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.copyBulkObbButton.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.copyBulkObbButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.copyBulkObbButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.copyBulkObbButton.FlatAppearance.BorderSize = 0;
            this.copyBulkObbButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copyBulkObbButton.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.copyBulkObbButton.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.copyBulkObbButton.Location = new System.Drawing.Point(0, 34);
            this.copyBulkObbButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.copyBulkObbButton.Name = "copyBulkObbButton";
            this.copyBulkObbButton.Padding = new System.Windows.Forms.Padding(31, 0, 0, 0);
            this.copyBulkObbButton.Size = new System.Drawing.Size(291, 34);
            this.copyBulkObbButton.TabIndex = 1;
            this.copyBulkObbButton.Text = "Recursive Copy OBB";
            this.copyBulkObbButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.copyBulkObbButton.UseVisualStyleBackColor = false;
            this.copyBulkObbButton.Click += new System.EventHandler(this.copyBulkObbButton_Click);
            // 
            // downloadInstallGameButton
            // 
            this.downloadInstallGameButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.downloadInstallGameButton.BackColor = global::AndroidSideloader.Properties.Settings.Default.SubButtonColor;
            this.downloadInstallGameButton.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "SubButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.downloadInstallGameButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.downloadInstallGameButton.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.downloadInstallGameButton.Enabled = false;
            this.downloadInstallGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downloadInstallGameButton.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.downloadInstallGameButton.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.downloadInstallGameButton.Location = new System.Drawing.Point(801, 540);
            this.downloadInstallGameButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.downloadInstallGameButton.Name = "downloadInstallGameButton";
            this.downloadInstallGameButton.Size = new System.Drawing.Size(495, 37);
            this.downloadInstallGameButton.TabIndex = 8;
            this.downloadInstallGameButton.Text = "Download and Install Game/Add to Queue";
            this.downloadInstallGameButton.UseVisualStyleBackColor = false;
            this.downloadInstallGameButton.Click += new System.EventHandler(this.downloadInstallGameButton_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = global::AndroidSideloader.Properties.Settings.Default.ButtonColor;
            this.panel1.Controls.Add(this.downloadingLabel);
            this.panel1.Controls.Add(this.aboutBtn);
            this.panel1.Controls.Add(this.settingsButton);
            this.panel1.Controls.Add(this.otherContainer);
            this.panel1.Controls.Add(this.otherDrop);
            this.panel1.Controls.Add(this.backupContainer);
            this.panel1.Controls.Add(this.backupDrop);
            this.panel1.Controls.Add(this.sideloadContainer);
            this.panel1.Controls.Add(this.sideloadDrop);
            this.panel1.Controls.Add(this.devicesbutton);
            this.panel1.Controls.Add(this.diskLabel);
            this.panel1.Controls.Add(this.speedLabel);
            this.panel1.Controls.Add(this.etaLabel);
            this.panel1.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "ButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 887);
            this.panel1.TabIndex = 73;
            // 
            // downloadingLabel
            // 
            this.downloadingLabel.AutoSize = true;
            this.downloadingLabel.BackColor = System.Drawing.SystemColors.WindowText;
            this.downloadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.downloadingLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.downloadingLabel.Location = new System.Drawing.Point(-4, 847);
            this.downloadingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.downloadingLabel.Name = "downloadingLabel";
            this.downloadingLabel.Size = new System.Drawing.Size(0, 24);
            this.downloadingLabel.TabIndex = 83;
            // 
            // aboutBtn
            // 
            this.aboutBtn.BackColor = global::AndroidSideloader.Properties.Settings.Default.ButtonColor;
            this.aboutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aboutBtn.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.aboutBtn.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "ButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.aboutBtn.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.aboutBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.aboutBtn.FlatAppearance.BorderSize = 0;
            this.aboutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutBtn.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.aboutBtn.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.aboutBtn.Location = new System.Drawing.Point(0, 732);
            this.aboutBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(291, 34);
            this.aboutBtn.TabIndex = 5;
            this.aboutBtn.Text = "ABOUT";
            this.aboutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aboutBtn.UseVisualStyleBackColor = false;
            this.aboutBtn.Click += new System.EventHandler(this.aboutBtn_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = global::AndroidSideloader.Properties.Settings.Default.ButtonColor;
            this.settingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsButton.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.settingsButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.settingsButton.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "ButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.settingsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingsButton.FlatAppearance.BorderSize = 0;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.settingsButton.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.settingsButton.Location = new System.Drawing.Point(0, 698);
            this.settingsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(291, 34);
            this.settingsButton.TabIndex = 4;
            this.settingsButton.Text = "SETTINGS";
            this.settingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // otherContainer
            // 
            this.otherContainer.BackColor = global::AndroidSideloader.Properties.Settings.Default.SubButtonColor;
            this.otherContainer.Controls.Add(this.InstallQUset);
            this.otherContainer.Controls.Add(this.removeQUSetting);
            this.otherContainer.Controls.Add(this.ThemeChangerButton);
            this.otherContainer.Controls.Add(this.QuestOptionsButton);
            this.otherContainer.Controls.Add(this.ADBWirelessDisable);
            this.otherContainer.Controls.Add(this.ADBWirelessEnable);
            this.otherContainer.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "SubButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.otherContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.otherContainer.Location = new System.Drawing.Point(0, 492);
            this.otherContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.otherContainer.Name = "otherContainer";
            this.otherContainer.Size = new System.Drawing.Size(291, 206);
            this.otherContainer.TabIndex = 80;
            // 
            // InstallQUset
            // 
            this.InstallQUset.BackColor = global::AndroidSideloader.Properties.Settings.Default.SubButtonColor;
            this.InstallQUset.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "SubButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.InstallQUset.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.InstallQUset.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.InstallQUset.Dock = System.Windows.Forms.DockStyle.Top;
            this.InstallQUset.FlatAppearance.BorderSize = 0;
            this.InstallQUset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InstallQUset.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.InstallQUset.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.InstallQUset.Location = new System.Drawing.Point(0, 170);
            this.InstallQUset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InstallQUset.Name = "InstallQUset";
            this.InstallQUset.Padding = new System.Windows.Forms.Padding(31, 0, 0, 0);
            this.InstallQUset.Size = new System.Drawing.Size(291, 34);
            this.InstallQUset.TabIndex = 5;
            this.InstallQUset.Text = "Install QU Setting";
            this.InstallQUset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InstallQUset.UseVisualStyleBackColor = false;
            this.InstallQUset.Click += new System.EventHandler(this.InstallQUset_Click);
            // 
            // removeQUSetting
            // 
            this.removeQUSetting.BackColor = global::AndroidSideloader.Properties.Settings.Default.SubButtonColor;
            this.removeQUSetting.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "SubButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.removeQUSetting.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.removeQUSetting.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.removeQUSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.removeQUSetting.FlatAppearance.BorderSize = 0;
            this.removeQUSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeQUSetting.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.removeQUSetting.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.removeQUSetting.Location = new System.Drawing.Point(0, 136);
            this.removeQUSetting.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.removeQUSetting.Name = "removeQUSetting";
            this.removeQUSetting.Padding = new System.Windows.Forms.Padding(31, 0, 0, 0);
            this.removeQUSetting.Size = new System.Drawing.Size(291, 34);
            this.removeQUSetting.TabIndex = 4;
            this.removeQUSetting.Text = "Remove QU Setting";
            this.removeQUSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.removeQUSetting.UseVisualStyleBackColor = false;
            this.removeQUSetting.Click += new System.EventHandler(this.removeQUSetting_Click);
            // 
            // ThemeChangerButton
            // 
            this.ThemeChangerButton.BackColor = global::AndroidSideloader.Properties.Settings.Default.SubButtonColor;
            this.ThemeChangerButton.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "SubButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ThemeChangerButton.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ThemeChangerButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ThemeChangerButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ThemeChangerButton.FlatAppearance.BorderSize = 0;
            this.ThemeChangerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ThemeChangerButton.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.ThemeChangerButton.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.ThemeChangerButton.Location = new System.Drawing.Point(0, 102);
            this.ThemeChangerButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ThemeChangerButton.Name = "ThemeChangerButton";
            this.ThemeChangerButton.Padding = new System.Windows.Forms.Padding(31, 0, 0, 0);
            this.ThemeChangerButton.Size = new System.Drawing.Size(291, 34);
            this.ThemeChangerButton.TabIndex = 3;
            this.ThemeChangerButton.Text = "Theme Changer";
            this.ThemeChangerButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ThemeChangerButton.UseVisualStyleBackColor = false;
            this.ThemeChangerButton.Click += new System.EventHandler(this.ThemeChangerButton_Click);
            // 
            // QuestOptionsButton
            // 
            this.QuestOptionsButton.BackColor = global::AndroidSideloader.Properties.Settings.Default.SubButtonColor;
            this.QuestOptionsButton.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "SubButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.QuestOptionsButton.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.QuestOptionsButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.QuestOptionsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.QuestOptionsButton.FlatAppearance.BorderSize = 0;
            this.QuestOptionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuestOptionsButton.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.QuestOptionsButton.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.QuestOptionsButton.Location = new System.Drawing.Point(0, 68);
            this.QuestOptionsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.QuestOptionsButton.Name = "QuestOptionsButton";
            this.QuestOptionsButton.Padding = new System.Windows.Forms.Padding(31, 0, 0, 0);
            this.QuestOptionsButton.Size = new System.Drawing.Size(291, 34);
            this.QuestOptionsButton.TabIndex = 2;
            this.QuestOptionsButton.Text = "Quest Options";
            this.QuestOptionsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.QuestOptionsButton.UseVisualStyleBackColor = false;
            this.QuestOptionsButton.Click += new System.EventHandler(this.QuestOptionsButton_Click);
            // 
            // ADBWirelessDisable
            // 
            this.ADBWirelessDisable.BackColor = global::AndroidSideloader.Properties.Settings.Default.SubButtonColor;
            this.ADBWirelessDisable.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "SubButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ADBWirelessDisable.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ADBWirelessDisable.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ADBWirelessDisable.Dock = System.Windows.Forms.DockStyle.Top;
            this.ADBWirelessDisable.FlatAppearance.BorderSize = 0;
            this.ADBWirelessDisable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ADBWirelessDisable.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.ADBWirelessDisable.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.ADBWirelessDisable.Location = new System.Drawing.Point(0, 34);
            this.ADBWirelessDisable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ADBWirelessDisable.Name = "ADBWirelessDisable";
            this.ADBWirelessDisable.Padding = new System.Windows.Forms.Padding(31, 0, 0, 0);
            this.ADBWirelessDisable.Size = new System.Drawing.Size(291, 34);
            this.ADBWirelessDisable.TabIndex = 1;
            this.ADBWirelessDisable.Text = "Disable WIreless ADB";
            this.ADBWirelessDisable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ADBWirelessDisable.UseVisualStyleBackColor = false;
            this.ADBWirelessDisable.Click += new System.EventHandler(this.ADBWirelessDisable_Click);
            // 
            // ADBWirelessEnable
            // 
            this.ADBWirelessEnable.BackColor = global::AndroidSideloader.Properties.Settings.Default.SubButtonColor;
            this.ADBWirelessEnable.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "SubButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ADBWirelessEnable.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ADBWirelessEnable.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ADBWirelessEnable.Dock = System.Windows.Forms.DockStyle.Top;
            this.ADBWirelessEnable.FlatAppearance.BorderSize = 0;
            this.ADBWirelessEnable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ADBWirelessEnable.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.ADBWirelessEnable.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.ADBWirelessEnable.Location = new System.Drawing.Point(0, 0);
            this.ADBWirelessEnable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ADBWirelessEnable.Name = "ADBWirelessEnable";
            this.ADBWirelessEnable.Padding = new System.Windows.Forms.Padding(31, 0, 0, 0);
            this.ADBWirelessEnable.Size = new System.Drawing.Size(291, 34);
            this.ADBWirelessEnable.TabIndex = 0;
            this.ADBWirelessEnable.Text = "Enable Wireless ADB";
            this.ADBWirelessEnable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ADBWirelessEnable.UseVisualStyleBackColor = false;
            this.ADBWirelessEnable.Click += new System.EventHandler(this.ADBWirelessEnable_Click);
            // 
            // otherDrop
            // 
            this.otherDrop.BackColor = global::AndroidSideloader.Properties.Settings.Default.ButtonColor;
            this.otherDrop.Cursor = System.Windows.Forms.Cursors.Default;
            this.otherDrop.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.otherDrop.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.otherDrop.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "ButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.otherDrop.Dock = System.Windows.Forms.DockStyle.Top;
            this.otherDrop.FlatAppearance.BorderSize = 0;
            this.otherDrop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.otherDrop.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.otherDrop.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.otherDrop.Location = new System.Drawing.Point(0, 458);
            this.otherDrop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.otherDrop.Name = "otherDrop";
            this.otherDrop.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.otherDrop.Size = new System.Drawing.Size(291, 34);
            this.otherDrop.TabIndex = 3;
            this.otherDrop.Text = "> OTHER";
            this.otherDrop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.otherDrop.UseVisualStyleBackColor = false;
            this.otherDrop.Click += new System.EventHandler(this.otherDrop_Click);
            // 
            // backupContainer
            // 
            this.backupContainer.BackColor = global::AndroidSideloader.Properties.Settings.Default.SubButtonColor;
            this.backupContainer.Controls.Add(this.backupbutton);
            this.backupContainer.Controls.Add(this.restorebutton);
            this.backupContainer.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "SubButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.backupContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.backupContainer.Location = new System.Drawing.Point(0, 384);
            this.backupContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backupContainer.Name = "backupContainer";
            this.backupContainer.Size = new System.Drawing.Size(291, 74);
            this.backupContainer.TabIndex = 76;
            // 
            // backupDrop
            // 
            this.backupDrop.BackColor = global::AndroidSideloader.Properties.Settings.Default.ButtonColor;
            this.backupDrop.Cursor = System.Windows.Forms.Cursors.Default;
            this.backupDrop.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.backupDrop.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.backupDrop.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "ButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.backupDrop.Dock = System.Windows.Forms.DockStyle.Top;
            this.backupDrop.FlatAppearance.BorderSize = 0;
            this.backupDrop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backupDrop.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.backupDrop.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.backupDrop.Location = new System.Drawing.Point(0, 350);
            this.backupDrop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backupDrop.Name = "backupDrop";
            this.backupDrop.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.backupDrop.Size = new System.Drawing.Size(291, 34);
            this.backupDrop.TabIndex = 2;
            this.backupDrop.Text = "> BACKUP";
            this.backupDrop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backupDrop.UseVisualStyleBackColor = false;
            this.backupDrop.Click += new System.EventHandler(this.backupDrop_Click);
            // 
            // sideloadContainer
            // 
            this.sideloadContainer.BackColor = global::AndroidSideloader.Properties.Settings.Default.SubButtonColor;
            this.sideloadContainer.Controls.Add(this.UpdateGamesButton);
            this.sideloadContainer.Controls.Add(this.listApkButton);
            this.sideloadContainer.Controls.Add(this.startsideloadbutton);
            this.sideloadContainer.Controls.Add(this.sideloadFolderButton);
            this.sideloadContainer.Controls.Add(this.uninstallAppButton);
            this.sideloadContainer.Controls.Add(this.getApkButton);
            this.sideloadContainer.Controls.Add(this.copyBulkObbButton);
            this.sideloadContainer.Controls.Add(this.obbcopybutton);
            this.sideloadContainer.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "SubButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.sideloadContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.sideloadContainer.Location = new System.Drawing.Point(0, 68);
            this.sideloadContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sideloadContainer.Name = "sideloadContainer";
            this.sideloadContainer.Size = new System.Drawing.Size(291, 282);
            this.sideloadContainer.TabIndex = 74;
            // 
            // UpdateGamesButton
            // 
            this.UpdateGamesButton.BackColor = global::AndroidSideloader.Properties.Settings.Default.SubButtonColor;
            this.UpdateGamesButton.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.UpdateGamesButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.UpdateGamesButton.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "SubButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.UpdateGamesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpdateGamesButton.FlatAppearance.BorderSize = 0;
            this.UpdateGamesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateGamesButton.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.UpdateGamesButton.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.UpdateGamesButton.Location = new System.Drawing.Point(0, 238);
            this.UpdateGamesButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UpdateGamesButton.Name = "UpdateGamesButton";
            this.UpdateGamesButton.Padding = new System.Windows.Forms.Padding(31, 0, 0, 0);
            this.UpdateGamesButton.Size = new System.Drawing.Size(291, 34);
            this.UpdateGamesButton.TabIndex = 7;
            this.UpdateGamesButton.Text = "Refresh Update List";
            this.UpdateGamesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UpdateGamesButton.UseVisualStyleBackColor = false;
            this.UpdateGamesButton.Click += new System.EventHandler(this.UpdateGamesButton_Click);
            // 
            // listApkButton
            // 
            this.listApkButton.BackColor = global::AndroidSideloader.Properties.Settings.Default.SubButtonColor;
            this.listApkButton.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.listApkButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.listApkButton.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "SubButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.listApkButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.listApkButton.FlatAppearance.BorderSize = 0;
            this.listApkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listApkButton.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.listApkButton.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.listApkButton.Location = new System.Drawing.Point(0, 204);
            this.listApkButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listApkButton.Name = "listApkButton";
            this.listApkButton.Padding = new System.Windows.Forms.Padding(31, 0, 0, 0);
            this.listApkButton.Size = new System.Drawing.Size(291, 34);
            this.listApkButton.TabIndex = 6;
            this.listApkButton.Text = "Refresh All";
            this.listApkButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.listApkButton.UseVisualStyleBackColor = false;
            this.listApkButton.Click += new System.EventHandler(this.listApkButton_Click);
            // 
            // sideloadDrop
            // 
            this.sideloadDrop.BackColor = global::AndroidSideloader.Properties.Settings.Default.ButtonColor;
            this.sideloadDrop.Cursor = System.Windows.Forms.Cursors.Default;
            this.sideloadDrop.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.sideloadDrop.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "ButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.sideloadDrop.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.sideloadDrop.Dock = System.Windows.Forms.DockStyle.Top;
            this.sideloadDrop.FlatAppearance.BorderSize = 0;
            this.sideloadDrop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sideloadDrop.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.sideloadDrop.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.sideloadDrop.Location = new System.Drawing.Point(0, 34);
            this.sideloadDrop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sideloadDrop.Name = "sideloadDrop";
            this.sideloadDrop.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.sideloadDrop.Size = new System.Drawing.Size(291, 34);
            this.sideloadDrop.TabIndex = 1;
            this.sideloadDrop.Text = "> SIDELOAD";
            this.sideloadDrop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sideloadDrop.UseVisualStyleBackColor = false;
            this.sideloadDrop.Click += new System.EventHandler(this.sideloadContainer_Click);
            // 
            // diskLabel
            // 
            this.diskLabel.AutoSize = true;
            this.diskLabel.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.diskLabel.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.diskLabel.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.diskLabel.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.diskLabel.Location = new System.Drawing.Point(4, 767);
            this.diskLabel.Name = "diskLabel";
            this.diskLabel.Size = new System.Drawing.Size(113, 25);
            this.diskLabel.TabIndex = 7;
            this.diskLabel.Text = "Disk Label";
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.speedLabel.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.speedLabel.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.speedLabel.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.speedLabel.Location = new System.Drawing.Point(0, 838);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(220, 25);
            this.speedLabel.TabIndex = 76;
            this.speedLabel.Text = "DLS: Speed in MBPS";
            // 
            // etaLabel
            // 
            this.etaLabel.AutoSize = true;
            this.etaLabel.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.etaLabel.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.etaLabel.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.etaLabel.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.etaLabel.Location = new System.Drawing.Point(0, 859);
            this.etaLabel.Name = "etaLabel";
            this.etaLabel.Size = new System.Drawing.Size(220, 25);
            this.etaLabel.TabIndex = 75;
            this.etaLabel.Text = "ETA: HH:MM:SS Left";
            // 
            // freeDisclaimer
            // 
            this.freeDisclaimer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.freeDisclaimer.AutoSize = true;
            this.freeDisclaimer.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.freeDisclaimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.freeDisclaimer.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.freeDisclaimer.Location = new System.Drawing.Point(369, 682);
            this.freeDisclaimer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.freeDisclaimer.Name = "freeDisclaimer";
            this.freeDisclaimer.Size = new System.Drawing.Size(294, 50);
            this.freeDisclaimer.TabIndex = 79;
            this.freeDisclaimer.Text = "This app is FREE!! \r\nClick here to go to the github.";
            this.freeDisclaimer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.freeDisclaimer.Click += new System.EventHandler(this.freeDisclaimer_Click);
            // 
            // gamesQueListBox
            // 
            this.gamesQueListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gamesQueListBox.BackColor = global::AndroidSideloader.Properties.Settings.Default.BackColor;
            this.gamesQueListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gamesQueListBox.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.gamesQueListBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.gamesQueListBox.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "BackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.gamesQueListBox.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.gamesQueListBox.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.gamesQueListBox.FormattingEnabled = true;
            this.gamesQueListBox.ItemHeight = 25;
            this.gamesQueListBox.Location = new System.Drawing.Point(801, 585);
            this.gamesQueListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gamesQueListBox.Name = "gamesQueListBox";
            this.gamesQueListBox.Size = new System.Drawing.Size(495, 152);
            this.gamesQueListBox.TabIndex = 9;
            this.gamesQueListBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gamesQueListBox_MouseClick);
            // 
            // devicesComboBox
            // 
            this.devicesComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.devicesComboBox.BackColor = global::AndroidSideloader.Properties.Settings.Default.ComboBoxColor;
            this.devicesComboBox.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "ComboBoxColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.devicesComboBox.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.devicesComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.devicesComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.devicesComboBox.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.devicesComboBox.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.devicesComboBox.FormattingEnabled = true;
            this.devicesComboBox.Location = new System.Drawing.Point(303, 48);
            this.devicesComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.devicesComboBox.Name = "devicesComboBox";
            this.devicesComboBox.Size = new System.Drawing.Size(213, 33);
            this.devicesComboBox.TabIndex = 1;
            this.devicesComboBox.Text = "Select your device";
            this.devicesComboBox.SelectedIndexChanged += new System.EventHandler(this.devicesComboBox_SelectedIndexChanged);
            // 
            // remotesList
            // 
            this.remotesList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.remotesList.BackColor = global::AndroidSideloader.Properties.Settings.Default.ComboBoxColor;
            this.remotesList.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "ComboBoxColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.remotesList.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.remotesList.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.remotesList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.remotesList.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.remotesList.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.remotesList.FormattingEnabled = true;
            this.remotesList.Location = new System.Drawing.Point(703, 48);
            this.remotesList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.remotesList.Name = "remotesList";
            this.remotesList.Size = new System.Drawing.Size(69, 33);
            this.remotesList.TabIndex = 3;
            this.remotesList.SelectedIndexChanged += new System.EventHandler(this.remotesList_SelectedIndexChanged);
            // 
            // gamesListView
            // 
            this.gamesListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gamesListView.BackColor = global::AndroidSideloader.Properties.Settings.Default.BackColor;
            this.gamesListView.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "BackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.gamesListView.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.gamesListView.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.gamesListView.HideSelection = false;
            this.gamesListView.Location = new System.Drawing.Point(304, 84);
            this.gamesListView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gamesListView.Name = "gamesListView";
            this.gamesListView.Size = new System.Drawing.Size(992, 450);
            this.gamesListView.TabIndex = 6;
            this.gamesListView.UseCompatibleStateImageBehavior = false;
            this.gamesListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            this.gamesListView.SelectedIndexChanged += new System.EventHandler(this.gamesListView_SelectedIndexChanged);
            this.gamesListView.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gamesListView_KeyPress);
            this.gamesListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gamesListView_MouseDoubleClick);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTextBox.BackColor = global::AndroidSideloader.Properties.Settings.Default.TextBoxColor;
            this.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchTextBox.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "TextBoxColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.searchTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.searchTextBox.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.searchTextBox.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.searchTextBox.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.searchTextBox.Location = new System.Drawing.Point(645, 308);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(307, 30);
            this.searchTextBox.TabIndex = 5;
            this.searchTextBox.Text = "Search";
            this.searchTextBox.Visible = false;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            this.searchTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchTextBox_KeyPress);
            this.searchTextBox.Leave += new System.EventHandler(this.searchTextBox_Leave);
            // 
            // gamesQueueLabel
            // 
            this.gamesQueueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gamesQueueLabel.AutoSize = true;
            this.gamesQueueLabel.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.gamesQueueLabel.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.gamesQueueLabel.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.gamesQueueLabel.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.gamesQueueLabel.Location = new System.Drawing.Point(796, 731);
            this.gamesQueueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gamesQueueLabel.Name = "gamesQueueLabel";
            this.gamesQueueLabel.Size = new System.Drawing.Size(151, 25);
            this.gamesQueueLabel.TabIndex = 86;
            this.gamesQueueLabel.Text = "Games Queue";
            // 
            // MountButton
            // 
            this.MountButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MountButton.BackColor = global::AndroidSideloader.Properties.Settings.Default.SubButtonColor;
            this.MountButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MountButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.MountButton.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "SubButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.MountButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.MountButton.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.MountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MountButton.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.MountButton.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.MountButton.Location = new System.Drawing.Point(524, 48);
            this.MountButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MountButton.Name = "MountButton";
            this.MountButton.Size = new System.Drawing.Size(88, 32);
            this.MountButton.TabIndex = 2;
            this.MountButton.Text = "Mount";
            this.MountButton.UseVisualStyleBackColor = false;
            this.MountButton.Click += new System.EventHandler(this.MountButton_Click);
            this.MountButton.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            // 
            // ProgressText
            // 
            this.ProgressText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ProgressText.AutoSize = true;
            this.ProgressText.BackColor = System.Drawing.Color.Transparent;
            this.ProgressText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgressText.ForeColor = System.Drawing.Color.White;
            this.ProgressText.Location = new System.Drawing.Point(300, 852);
            this.ProgressText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProgressText.Name = "ProgressText";
            this.ProgressText.Size = new System.Drawing.Size(0, 24);
            this.ProgressText.TabIndex = 88;
            // 
            // notesRichTextBox
            // 
            this.notesRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.notesRichTextBox.BackColor = global::AndroidSideloader.Properties.Settings.Default.BackColor;
            this.notesRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.notesRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "BackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.notesRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.notesRichTextBox.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.notesRichTextBox.HideSelection = false;
            this.notesRichTextBox.Location = new System.Drawing.Point(801, 751);
            this.notesRichTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.notesRichTextBox.Name = "notesRichTextBox";
            this.notesRichTextBox.ReadOnly = true;
            this.notesRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.notesRichTextBox.ShowSelectionMargin = true;
            this.notesRichTextBox.Size = new System.Drawing.Size(493, 96);
            this.notesRichTextBox.TabIndex = 10;
            this.notesRichTextBox.Text = "";
            // 
            // DragDropLbl
            // 
            this.DragDropLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DragDropLbl.AutoSize = true;
            this.DragDropLbl.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DragDropLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DragDropLbl.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.DragDropLbl.Location = new System.Drawing.Point(803, 626);
            this.DragDropLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DragDropLbl.Name = "DragDropLbl";
            this.DragDropLbl.Size = new System.Drawing.Size(394, 69);
            this.DragDropLbl.TabIndex = 25;
            this.DragDropLbl.Text = "DragDropLBL";
            this.DragDropLbl.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label1.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.label1.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.label1.Location = new System.Drawing.Point(797, 833);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 86;
            this.label1.Text = "Install Notes";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("ImageLocation", global::AndroidSideloader.Properties.Settings.Default, "BackPicturePath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.ImageLocation = global::AndroidSideloader.Properties.Settings.Default.BackPicturePath;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(289, -2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1019, 884);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 74;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label2.Location = new System.Drawing.Point(620, 241);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(361, 148);
            this.label2.TabIndex = 89;
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(688, 257);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 60);
            this.label3.TabIndex = 90;
            this.label3.Text = "Start typing to search.\r\nPress ESC to close.\r\n\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(709, 350);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 20);
            this.label4.TabIndex = 90;
            this.label4.Text = "Shorcut: CTRL+F";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(923, 14);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 20);
            this.label5.TabIndex = 90;
            this.label5.Text = "Search apps";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox3.Image = global::AndroidSideloader.Properties.Resources.orangekey;
            this.pictureBox3.Location = new System.Drawing.Point(1071, 12);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(28, 25);
            this.pictureBox3.TabIndex = 92;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.Image = global::AndroidSideloader.Properties.Resources.SearchGlass;
            this.pictureBox2.Location = new System.Drawing.Point(975, 46);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 30);
            this.pictureBox2.TabIndex = 91;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // gamesPictureBox
            // 
            this.gamesPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gamesPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gamesPictureBox.Location = new System.Drawing.Point(303, 581);
            this.gamesPictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gamesPictureBox.Name = "gamesPictureBox";
            this.gamesPictureBox.Size = new System.Drawing.Size(489, 263);
            this.gamesPictureBox.TabIndex = 84;
            this.gamesPictureBox.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox4.Image = global::AndroidSideloader.Properties.Resources.greenkey;
            this.pictureBox4.Location = new System.Drawing.Point(1071, 48);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(28, 25);
            this.pictureBox4.TabIndex = 92;
            this.pictureBox4.TabStop = false;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(1104, 15);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 20);
            this.label6.TabIndex = 90;
            this.label6.Text = "= Update Available";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(1104, 50);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 20);
            this.label7.TabIndex = 90;
            this.label7.Text = "= Up to date";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(612, 52);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 20);
            this.label8.TabIndex = 90;
            this.label8.Text = "Mirror #";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // EnterInstallBox
            // 
            this.EnterInstallBox.AutoSize = true;
            this.EnterInstallBox.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EnterInstallBox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.EnterInstallBox.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.EnterInstallBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.EnterInstallBox.Location = new System.Drawing.Point(791, 9);
            this.EnterInstallBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EnterInstallBox.Name = "EnterInstallBox";
            this.EnterInstallBox.Size = new System.Drawing.Size(119, 71);
            this.EnterInstallBox.TabIndex = 93;
            this.EnterInstallBox.Text = "  Install w/ \r\n Enter Key";
            this.EnterInstallBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EnterInstallBox.UseVisualStyleBackColor = true;
            this.EnterInstallBox.CheckedChanged += new System.EventHandler(this.EnterInstallBox_CheckedChanged);
            // 
            // ADBcommandbox
            // 
            this.ADBcommandbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ADBcommandbox.BackColor = global::AndroidSideloader.Properties.Settings.Default.TextBoxColor;
            this.ADBcommandbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ADBcommandbox.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "TextBoxColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ADBcommandbox.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::AndroidSideloader.Properties.Settings.Default, "FontStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ADBcommandbox.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::AndroidSideloader.Properties.Settings.Default, "FontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ADBcommandbox.Font = global::AndroidSideloader.Properties.Settings.Default.FontStyle;
            this.ADBcommandbox.ForeColor = global::AndroidSideloader.Properties.Settings.Default.FontColor;
            this.ADBcommandbox.Location = new System.Drawing.Point(645, 309);
            this.ADBcommandbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ADBcommandbox.Name = "ADBcommandbox";
            this.ADBcommandbox.Size = new System.Drawing.Size(307, 30);
            this.ADBcommandbox.TabIndex = 5;
            this.ADBcommandbox.Visible = false;
            this.ADBcommandbox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            this.ADBcommandbox.Enter += new System.EventHandler(this.ADBcommandbox_Enter);
            this.ADBcommandbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ADBcommandbox_KeyPress);
            this.ADBcommandbox.Leave += new System.EventHandler(this.ADBcommandbox_Leave);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(704, 351);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(169, 20);
            this.label11.TabIndex = 90;
            this.label11.Text = "Shorcut = CTRL+R";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label11.Visible = false;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(685, 254);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(207, 80);
            this.label9.TabIndex = 90;
            this.label9.Text = "Type command without \r\n\"adb\" prefix.\r\n\r\n\r\n";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label9.Visible = false;
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::AndroidSideloader.Properties.Settings.Default.BackColor;
            this.ClientSize = new System.Drawing.Size(1307, 887);
            this.Controls.Add(this.EnterInstallBox);
            this.Controls.Add(this.ProgressText);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ADBcommandbox);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.freeDisclaimer);
            this.Controls.Add(this.DragDropLbl);
            this.Controls.Add(this.MountButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gamesQueueLabel);
            this.Controls.Add(this.gamesPictureBox);
            this.Controls.Add(this.remotesList);
            this.Controls.Add(this.devicesComboBox);
            this.Controls.Add(this.gamesQueListBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.downloadInstallGameButton);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.m_combo);
            this.Controls.Add(this.notesRichTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gamesListView);
            this.Controls.Add(this.pictureBox1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::AndroidSideloader.Properties.Settings.Default, "BackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Rookie\'s Sideloader";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.DragLeave += new System.EventHandler(this.Form1_DragLeave);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.otherContainer.ResumeLayout(false);
            this.backupContainer.ResumeLayout(false);
            this.sideloadContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button startsideloadbutton;
        private System.Windows.Forms.Button devicesbutton;
        private System.Windows.Forms.Button obbcopybutton;
        private System.Windows.Forms.Button backupbutton;
        private System.Windows.Forms.Button restorebutton;
        private System.Windows.Forms.Button getApkButton;
        private SergeUtils.EasyCompletionComboBox m_combo;
        private System.Windows.Forms.Button uninstallAppButton;
        private System.Windows.Forms.Button sideloadFolderButton;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button copyBulkObbButton;
        private System.Windows.Forms.Button downloadInstallGameButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel backupContainer;
        private System.Windows.Forms.Button backupDrop;
        private System.Windows.Forms.Panel sideloadContainer;
        private System.Windows.Forms.Button sideloadDrop;
        private System.Windows.Forms.Button listApkButton;
        private System.Windows.Forms.Label etaLabel;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.Label diskLabel;
        private System.Windows.Forms.Button otherDrop;
        private System.Windows.Forms.Panel otherContainer;
        private System.Windows.Forms.Button ADBWirelessEnable;
        private System.Windows.Forms.Button aboutBtn;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button ADBWirelessDisable;
        private System.Windows.Forms.Label freeDisclaimer;
        private System.Windows.Forms.ComboBox devicesComboBox;
        private System.Windows.Forms.ComboBox remotesList;
        private System.Windows.Forms.Button QuestOptionsButton;
        private System.Windows.Forms.Button ThemeChangerButton;
        private System.Windows.Forms.ListBox gamesQueListBox;
        private System.Windows.Forms.ListView gamesListView;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.PictureBox gamesPictureBox;
        private System.Windows.Forms.Button UpdateGamesButton;
        private System.Windows.Forms.Label gamesQueueLabel;
        private System.Windows.Forms.Button MountButton;
        private System.Windows.Forms.Label ProgressText;
        private System.Windows.Forms.Label downloadingLabel;
        private System.Windows.Forms.RichTextBox notesRichTextBox;
        private System.Windows.Forms.Label DragDropLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button removeQUSetting;
        private System.Windows.Forms.Button InstallQUset;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox EnterInstallBox;
        private System.Windows.Forms.TextBox ADBcommandbox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
    }
}

