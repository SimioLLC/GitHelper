using System.Windows.Forms;
using System.ComponentModel;

namespace GitHelperAddIn
{
    partial class FormGitHelper
    {
        /////// <summary>
        /////// Required designer variable.
        /////// </summary>
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGitHelper));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labelStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabPages = new System.Windows.Forms.TabControl();
            this.tabCommands = new System.Windows.Forms.TabPage();
            this.panelCommands = new System.Windows.Forms.Panel();
            this.buttonLaunchFileExplorer = new System.Windows.Forms.Button();
            this.picWindowsLaunchFileExplorer = new System.Windows.Forms.PictureBox();
            this.buttonGitStatus = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picSimio1 = new System.Windows.Forms.PictureBox();
            this.buttonLaunchVSCode = new System.Windows.Forms.Button();
            this.buttonGetCurrentProjectionInfo = new System.Windows.Forms.Button();
            this.tabGitCommands = new System.Windows.Forms.TabPage();
            this.comboGitCommands = new System.Windows.Forms.ComboBox();
            this.buttonExecuteGitCommand = new System.Windows.Forms.Button();
            this.labelGitInstructions = new System.Windows.Forms.Label();
            this.tabGitClone = new System.Windows.Forms.TabPage();
            this.textLocalRepoName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSearchCloneFolder = new System.Windows.Forms.Button();
            this.buttonUrlPaste = new System.Windows.Forms.Button();
            this.textLocalParentFolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelRemoteRepository = new System.Windows.Forms.Label();
            this.labelCloneSimio = new System.Windows.Forms.Label();
            this.textRemoteUrl = new System.Windows.Forms.TextBox();
            this.buttonCloneSimioProject = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelInstructions = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.splitContainerTop = new System.Windows.Forms.SplitContainer();
            this.panelLogging = new System.Windows.Forms.Panel();
            this.textLogging = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelLogHeader = new System.Windows.Forms.Panel();
            this.labelLogInstructions = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabPages.SuspendLayout();
            this.tabCommands.SuspendLayout();
            this.panelCommands.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWindowsLaunchFileExplorer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSimio1)).BeginInit();
            this.tabGitCommands.SuspendLayout();
            this.tabGitClone.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTop)).BeginInit();
            this.splitContainerTop.Panel1.SuspendLayout();
            this.splitContainerTop.Panel2.SuspendLayout();
            this.splitContainerTop.SuspendLayout();
            this.panelLogging.SuspendLayout();
            this.panelLogHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1141, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(60, 25);
            this.closeToolStripMenuItem.Text = "&Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click_2);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(73, 25);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 624);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1141, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // labelStatus
            // 
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(16, 17);
            this.labelStatus.Text = "...";
            // 
            // tabPages
            // 
            this.tabPages.Controls.Add(this.tabCommands);
            this.tabPages.Controls.Add(this.tabGitCommands);
            this.tabPages.Controls.Add(this.tabGitClone);
            this.tabPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPages.Location = new System.Drawing.Point(0, 0);
            this.tabPages.Name = "tabPages";
            this.tabPages.SelectedIndex = 0;
            this.tabPages.Size = new System.Drawing.Size(1141, 253);
            this.tabPages.TabIndex = 2;
            // 
            // tabCommands
            // 
            this.tabCommands.Controls.Add(this.panelCommands);
            this.tabCommands.Location = new System.Drawing.Point(4, 26);
            this.tabCommands.Name = "tabCommands";
            this.tabCommands.Size = new System.Drawing.Size(1133, 223);
            this.tabCommands.TabIndex = 4;
            this.tabCommands.Text = "Commands";
            this.tabCommands.UseVisualStyleBackColor = true;
            // 
            // panelCommands
            // 
            this.panelCommands.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelCommands.Controls.Add(this.buttonLaunchFileExplorer);
            this.panelCommands.Controls.Add(this.picWindowsLaunchFileExplorer);
            this.panelCommands.Controls.Add(this.buttonGitStatus);
            this.panelCommands.Controls.Add(this.pictureBox2);
            this.panelCommands.Controls.Add(this.pictureBox1);
            this.panelCommands.Controls.Add(this.picSimio1);
            this.panelCommands.Controls.Add(this.buttonLaunchVSCode);
            this.panelCommands.Controls.Add(this.buttonGetCurrentProjectionInfo);
            this.panelCommands.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCommands.Location = new System.Drawing.Point(0, 0);
            this.panelCommands.Name = "panelCommands";
            this.panelCommands.Size = new System.Drawing.Size(1133, 223);
            this.panelCommands.TabIndex = 5;
            // 
            // buttonLaunchFileExplorer
            // 
            this.buttonLaunchFileExplorer.Location = new System.Drawing.Point(459, 101);
            this.buttonLaunchFileExplorer.Name = "buttonLaunchFileExplorer";
            this.buttonLaunchFileExplorer.Size = new System.Drawing.Size(241, 48);
            this.buttonLaunchFileExplorer.TabIndex = 16;
            this.buttonLaunchFileExplorer.Text = "Launch File Explorer...";
            this.toolTip1.SetToolTip(this.buttonLaunchFileExplorer, "Launch the File Exporer to the Project Folder");
            this.buttonLaunchFileExplorer.UseVisualStyleBackColor = true;
            this.buttonLaunchFileExplorer.Click += new System.EventHandler(this.buttonLaunchFileExplorer_Click);
            // 
            // picWindowsLaunchFileExplorer
            // 
            this.picWindowsLaunchFileExplorer.BackgroundImage = global::GitHelperAddIn.Properties.Resources.WindowsPng;
            this.picWindowsLaunchFileExplorer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picWindowsLaunchFileExplorer.Location = new System.Drawing.Point(392, 101);
            this.picWindowsLaunchFileExplorer.Name = "picWindowsLaunchFileExplorer";
            this.picWindowsLaunchFileExplorer.Size = new System.Drawing.Size(52, 48);
            this.picWindowsLaunchFileExplorer.TabIndex = 15;
            this.picWindowsLaunchFileExplorer.TabStop = false;
            // 
            // buttonGitStatus
            // 
            this.buttonGitStatus.Location = new System.Drawing.Point(459, 32);
            this.buttonGitStatus.Name = "buttonGitStatus";
            this.buttonGitStatus.Size = new System.Drawing.Size(241, 48);
            this.buttonGitStatus.TabIndex = 14;
            this.buttonGitStatus.Text = "Get Git Status";
            this.toolTip1.SetToolTip(this.buttonGitStatus, "Show Status information in the log window below");
            this.buttonGitStatus.UseVisualStyleBackColor = true;
            this.buttonGitStatus.Click += new System.EventHandler(this.buttonGitStatus_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::GitHelperAddIn.Properties.Resources.IconPng;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(392, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 48);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GitHelperAddIn.Properties.Resources.VSCodePng;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 48);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // picSimio1
            // 
            this.picSimio1.BackgroundImage = global::GitHelperAddIn.Properties.Resources.SimioPng;
            this.picSimio1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picSimio1.Location = new System.Drawing.Point(12, 32);
            this.picSimio1.Name = "picSimio1";
            this.picSimio1.Size = new System.Drawing.Size(52, 48);
            this.picSimio1.TabIndex = 11;
            this.picSimio1.TabStop = false;
            // 
            // buttonLaunchVSCode
            // 
            this.buttonLaunchVSCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLaunchVSCode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLaunchVSCode.Location = new System.Drawing.Point(79, 101);
            this.buttonLaunchVSCode.Name = "buttonLaunchVSCode";
            this.buttonLaunchVSCode.Size = new System.Drawing.Size(241, 48);
            this.buttonLaunchVSCode.TabIndex = 10;
            this.buttonLaunchVSCode.Text = "Launch VSCode";
            this.buttonLaunchVSCode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.buttonLaunchVSCode, "Launch VSCode for the currently loaded Simio project");
            this.buttonLaunchVSCode.UseVisualStyleBackColor = true;
            this.buttonLaunchVSCode.Click += new System.EventHandler(this.buttonLaunchVSCode_Click);
            // 
            // buttonGetCurrentProjectionInfo
            // 
            this.buttonGetCurrentProjectionInfo.Location = new System.Drawing.Point(79, 32);
            this.buttonGetCurrentProjectionInfo.Name = "buttonGetCurrentProjectionInfo";
            this.buttonGetCurrentProjectionInfo.Size = new System.Drawing.Size(241, 48);
            this.buttonGetCurrentProjectionInfo.TabIndex = 3;
            this.buttonGetCurrentProjectionInfo.Text = "Get Current Project Info";
            this.toolTip1.SetToolTip(this.buttonGetCurrentProjectionInfo, "Get information on the currently loaded project");
            this.buttonGetCurrentProjectionInfo.UseVisualStyleBackColor = true;
            this.buttonGetCurrentProjectionInfo.Click += new System.EventHandler(this.buttonGetCurrentProjectionInfo_Click);
            // 
            // tabGitCommands
            // 
            this.tabGitCommands.Controls.Add(this.comboGitCommands);
            this.tabGitCommands.Controls.Add(this.buttonExecuteGitCommand);
            this.tabGitCommands.Controls.Add(this.labelGitInstructions);
            this.tabGitCommands.Location = new System.Drawing.Point(4, 26);
            this.tabGitCommands.Name = "tabGitCommands";
            this.tabGitCommands.Size = new System.Drawing.Size(1133, 224);
            this.tabGitCommands.TabIndex = 6;
            this.tabGitCommands.Text = "Git Commands";
            this.tabGitCommands.UseVisualStyleBackColor = true;
            // 
            // comboGitCommands
            // 
            this.comboGitCommands.FormattingEnabled = true;
            this.comboGitCommands.Location = new System.Drawing.Point(12, 44);
            this.comboGitCommands.Name = "comboGitCommands";
            this.comboGitCommands.Size = new System.Drawing.Size(638, 25);
            this.comboGitCommands.TabIndex = 32;
            this.comboGitCommands.SelectedIndexChanged += new System.EventHandler(this.comboGitCommands_SelectedIndexChanged);
            // 
            // buttonExecuteGitCommand
            // 
            this.buttonExecuteGitCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExecuteGitCommand.Location = new System.Drawing.Point(806, 31);
            this.buttonExecuteGitCommand.Name = "buttonExecuteGitCommand";
            this.buttonExecuteGitCommand.Size = new System.Drawing.Size(192, 48);
            this.buttonExecuteGitCommand.TabIndex = 31;
            this.buttonExecuteGitCommand.Text = "Execute Command";
            this.toolTip1.SetToolTip(this.buttonExecuteGitCommand, "Compute the Lon,Lat to Simio Facility View  transfrom.");
            this.buttonExecuteGitCommand.UseVisualStyleBackColor = true;
            // 
            // labelGitInstructions
            // 
            this.labelGitInstructions.AutoSize = true;
            this.labelGitInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGitInstructions.Location = new System.Drawing.Point(9, 14);
            this.labelGitInstructions.Name = "labelGitInstructions";
            this.labelGitInstructions.Size = new System.Drawing.Size(229, 17);
            this.labelGitInstructions.TabIndex = 29;
            this.labelGitInstructions.Text = "Select a command and view results";
            // 
            // tabGitClone
            // 
            this.tabGitClone.Controls.Add(this.textLocalRepoName);
            this.tabGitClone.Controls.Add(this.label2);
            this.tabGitClone.Controls.Add(this.buttonSearchCloneFolder);
            this.tabGitClone.Controls.Add(this.buttonUrlPaste);
            this.tabGitClone.Controls.Add(this.textLocalParentFolder);
            this.tabGitClone.Controls.Add(this.label1);
            this.tabGitClone.Controls.Add(this.labelRemoteRepository);
            this.tabGitClone.Controls.Add(this.labelCloneSimio);
            this.tabGitClone.Controls.Add(this.textRemoteUrl);
            this.tabGitClone.Controls.Add(this.buttonCloneSimioProject);
            this.tabGitClone.Location = new System.Drawing.Point(4, 26);
            this.tabGitClone.Name = "tabGitClone";
            this.tabGitClone.Size = new System.Drawing.Size(1133, 224);
            this.tabGitClone.TabIndex = 7;
            this.tabGitClone.Text = "Clone Simio Project";
            this.tabGitClone.UseVisualStyleBackColor = true;
            // 
            // textLocalRepoName
            // 
            this.textLocalRepoName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textLocalRepoName.Location = new System.Drawing.Point(202, 144);
            this.textLocalRepoName.Name = "textLocalRepoName";
            this.textLocalRepoName.Size = new System.Drawing.Size(327, 23);
            this.textLocalRepoName.TabIndex = 41;
            this.toolTip1.SetToolTip(this.textLocalRepoName, "Name for the local repository. Must be a legal folder name since it will reside u" +
        "nder the parent folder.");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 18);
            this.label2.TabIndex = 40;
            this.label2.Text = "Local Repository Folder";
            this.toolTip1.SetToolTip(this.label2, "The name for the local repository project folder, which will be a folder under th" +
        "e Parent");
            // 
            // buttonSearchCloneFolder
            // 
            this.buttonSearchCloneFolder.Location = new System.Drawing.Point(1047, 95);
            this.buttonSearchCloneFolder.Name = "buttonSearchCloneFolder";
            this.buttonSearchCloneFolder.Size = new System.Drawing.Size(78, 28);
            this.buttonSearchCloneFolder.TabIndex = 39;
            this.buttonSearchCloneFolder.Text = "...";
            this.toolTip1.SetToolTip(this.buttonSearchCloneFolder, "Open dialog to select folder");
            this.buttonSearchCloneFolder.UseVisualStyleBackColor = true;
            this.buttonSearchCloneFolder.Click += new System.EventHandler(this.buttonSearchCloneFolder_Click);
            // 
            // buttonUrlPaste
            // 
            this.buttonUrlPaste.Location = new System.Drawing.Point(1047, 54);
            this.buttonUrlPaste.Name = "buttonUrlPaste";
            this.buttonUrlPaste.Size = new System.Drawing.Size(78, 28);
            this.buttonUrlPaste.TabIndex = 38;
            this.buttonUrlPaste.Text = "Paste";
            this.toolTip1.SetToolTip(this.buttonUrlPaste, "Paste from clipboard");
            this.buttonUrlPaste.UseVisualStyleBackColor = true;
            this.buttonUrlPaste.Click += new System.EventHandler(this.buttonUrlPaste_Click);
            // 
            // textLocalParentFolder
            // 
            this.textLocalParentFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textLocalParentFolder.Location = new System.Drawing.Point(202, 98);
            this.textLocalParentFolder.Name = "textLocalParentFolder";
            this.textLocalParentFolder.Size = new System.Drawing.Size(839, 23);
            this.textLocalParentFolder.TabIndex = 37;
            this.toolTip1.SetToolTip(this.textLocalParentFolder, "The parent folder for you local repository. It must exist.");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 18);
            this.label1.TabIndex = 36;
            this.label1.Text = "Local Parent Folder Path";
            this.toolTip1.SetToolTip(this.label1, "The folder under which the local repository will reside");
            // 
            // labelRemoteRepository
            // 
            this.labelRemoteRepository.AutoSize = true;
            this.labelRemoteRepository.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRemoteRepository.Location = new System.Drawing.Point(9, 59);
            this.labelRemoteRepository.Name = "labelRemoteRepository";
            this.labelRemoteRepository.Size = new System.Drawing.Size(171, 18);
            this.labelRemoteRepository.TabIndex = 35;
            this.labelRemoteRepository.Text = "Remote Repository URL";
            // 
            // labelCloneSimio
            // 
            this.labelCloneSimio.AutoSize = true;
            this.labelCloneSimio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCloneSimio.Location = new System.Drawing.Point(9, 10);
            this.labelCloneSimio.Name = "labelCloneSimio";
            this.labelCloneSimio.Size = new System.Drawing.Size(867, 17);
            this.labelCloneSimio.TabIndex = 34;
            this.labelCloneSimio.Text = "Clone a Simio project from the remote repository to a local folder (which must be" +
    " empty) under a Parent Folder (which must already exist)";
            // 
            // textRemoteUrl
            // 
            this.textRemoteUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textRemoteUrl.Location = new System.Drawing.Point(202, 57);
            this.textRemoteUrl.Name = "textRemoteUrl";
            this.textRemoteUrl.Size = new System.Drawing.Size(839, 23);
            this.textRemoteUrl.TabIndex = 33;
            this.toolTip1.SetToolTip(this.textRemoteUrl, "The URL of the remote repository. E.g. GitHub will supply this URL under the Code" +
        " button.");
            // 
            // buttonCloneSimioProject
            // 
            this.buttonCloneSimioProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCloneSimioProject.Location = new System.Drawing.Point(849, 131);
            this.buttonCloneSimioProject.Name = "buttonCloneSimioProject";
            this.buttonCloneSimioProject.Size = new System.Drawing.Size(192, 48);
            this.buttonCloneSimioProject.TabIndex = 32;
            this.buttonCloneSimioProject.Text = "Clone Simio Project";
            this.toolTip1.SetToolTip(this.buttonCloneSimioProject, "Get a copy of a Simio project from the URL and place in the Local Folder");
            this.buttonCloneSimioProject.UseVisualStyleBackColor = true;
            this.buttonCloneSimioProject.Click += new System.EventHandler(this.buttonCloneSimioProject_Click);
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.labelInstructions);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1141, 44);
            this.panelTop.TabIndex = 3;
            // 
            // labelInstructions
            // 
            this.labelInstructions.AutoSize = true;
            this.labelInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInstructions.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelInstructions.Location = new System.Drawing.Point(12, 11);
            this.labelInstructions.Name = "labelInstructions";
            this.labelInstructions.Size = new System.Drawing.Size(408, 20);
            this.labelInstructions.TabIndex = 9;
            this.labelInstructions.Text = "Save your Simio Project and then perform Git Operations";
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.SystemColors.Control;
            this.panelContent.Controls.Add(this.splitContainerTop);
            this.panelContent.Controls.Add(this.panelTop);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 29);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1141, 595);
            this.panelContent.TabIndex = 4;
            // 
            // splitContainerTop
            // 
            this.splitContainerTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerTop.Location = new System.Drawing.Point(0, 44);
            this.splitContainerTop.Name = "splitContainerTop";
            this.splitContainerTop.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerTop.Panel1
            // 
            this.splitContainerTop.Panel1.Controls.Add(this.tabPages);
            // 
            // splitContainerTop.Panel2
            // 
            this.splitContainerTop.Panel2.Controls.Add(this.panelLogging);
            this.splitContainerTop.Size = new System.Drawing.Size(1141, 551);
            this.splitContainerTop.SplitterDistance = 253;
            this.splitContainerTop.TabIndex = 5;
            // 
            // panelLogging
            // 
            this.panelLogging.BackColor = System.Drawing.SystemColors.Control;
            this.panelLogging.Controls.Add(this.textLogging);
            this.panelLogging.Controls.Add(this.panelLogHeader);
            this.panelLogging.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLogging.Location = new System.Drawing.Point(0, 0);
            this.panelLogging.Name = "panelLogging";
            this.panelLogging.Size = new System.Drawing.Size(1141, 294);
            this.panelLogging.TabIndex = 4;
            // 
            // textLogging
            // 
            this.textLogging.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textLogging.Location = new System.Drawing.Point(0, 41);
            this.textLogging.Multiline = true;
            this.textLogging.Name = "textLogging";
            this.textLogging.ReadOnly = true;
            this.textLogging.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textLogging.Size = new System.Drawing.Size(1141, 253);
            this.textLogging.TabIndex = 31;
            this.textLogging.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.textLogging_MouseDoubleClick);
            // 
            // panelLogHeader
            // 
            this.panelLogHeader.Controls.Add(this.labelLogInstructions);
            this.panelLogHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogHeader.Location = new System.Drawing.Point(0, 0);
            this.panelLogHeader.Name = "panelLogHeader";
            this.panelLogHeader.Size = new System.Drawing.Size(1141, 41);
            this.panelLogHeader.TabIndex = 32;
            // 
            // labelLogInstructions
            // 
            this.labelLogInstructions.AutoSize = true;
            this.labelLogInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogInstructions.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelLogInstructions.Location = new System.Drawing.Point(12, 10);
            this.labelLogInstructions.Name = "labelLogInstructions";
            this.labelLogInstructions.Size = new System.Drawing.Size(261, 16);
            this.labelLogInstructions.TabIndex = 10;
            this.labelLogInstructions.Text = "Logging panel. Double-click panel to clear.";
            // 
            // FormGitHelper
            // 
            this.ClientSize = new System.Drawing.Size(1141, 646);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormGitHelper";
            this.Load += new System.EventHandler(this.FormGitHelpers_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabPages.ResumeLayout(false);
            this.tabCommands.ResumeLayout(false);
            this.panelCommands.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picWindowsLaunchFileExplorer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSimio1)).EndInit();
            this.tabGitCommands.ResumeLayout(false);
            this.tabGitCommands.PerformLayout();
            this.tabGitClone.ResumeLayout(false);
            this.tabGitClone.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.splitContainerTop.Panel1.ResumeLayout(false);
            this.splitContainerTop.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTop)).EndInit();
            this.splitContainerTop.ResumeLayout(false);
            this.panelLogging.ResumeLayout(false);
            this.panelLogging.PerformLayout();
            this.panelLogHeader.ResumeLayout(false);
            this.panelLogHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private MenuStrip menuStrip1;
        private ToolStripMenuItem closeToolStripMenuItem;
        private StatusStrip statusStrip1;
        private TabControl tabPages;
        private ToolStripStatusLabel labelStatus;
        private Panel panelTop;
        private Label labelInstructions;
        private Panel panelContent;
        private ToolTip toolTip1;
        //private IContainer components;
        private TabPage tabCommands;
        private TabPage tabGitCommands;
        private Label labelGitInstructions;
        private Panel panelCommands;
        private Button buttonGetCurrentProjectionInfo;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Button buttonExecuteGitCommand;
        private Panel panelLogging;
        private SplitContainer splitContainerTop;
        private TextBox textLogging;
        private Button buttonLaunchVSCode;
        private ComboBox comboGitCommands;
        private TabPage tabGitClone;
        private Label labelCloneSimio;
        private TextBox textRemoteUrl;
        private Button buttonCloneSimioProject;
        private TextBox textLocalParentFolder;
        private Label label1;
        private Label labelRemoteRepository;
        private Button buttonSearchCloneFolder;
        private Button buttonUrlPaste;
        private TextBox textLocalRepoName;
        private Label label2;
        private Button buttonGitStatus;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox picSimio1;
        private Button buttonLaunchFileExplorer;
        private PictureBox picWindowsLaunchFileExplorer;
        private Panel panelLogHeader;
        private Label labelLogInstructions;
    }

    #endregion
}
