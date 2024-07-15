﻿using SimioAPI;
using SimioAPI.Extensions;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace GitHelperAddIn
{
    public partial class FormGitHelper : Form
    {

        private ISimioProject _currentProject;
        private IDesignContext _context;

        internal IDesignContext SimioContext
        {
            get
            {
                return _context;
            }
            set
            {
                _context = value;
                _currentProject = _context.ActiveProject; 

                if (_currentProject == null)
                {
                    AlertAndLog("No project is currently open.");
                    return;
                }

            }
        }

        internal GitHelperContext GitHelperContext { get; set; }


        /// <summary>
        /// The path to the project folder
        /// </summary>
        private string ProjectFolderPath { get { return GitHelperContext.ProjectFolderPath; } }

        private string ProjectNameWithoutExtension { get { return GitHelperContext.SimioProjectName; } }



        internal Logger MyLogger { get; set; }

        public string ApplicationName { get; set; }

        public FormGitHelper()
        {
            InitializeComponent();

        }

        private void closeToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }


        private void FormGitHelpers_Load(object sender, EventArgs e)
        {
            try
            {
                MyLogger.OnUpdate += (message) =>
                {
                    textLogging.Text = MyLogger.GetLogs();
                };

                comboGitCommands.Items.Clear();
                comboGitCommands.Items.Add("Status");
                ////comboGitCommands.Items.Add("Version");
                ////comboGitCommands.Items.Add("Commit");

                Logit($"Loaded Git Helper for {ApplicationName}. ProjectFolder={this.ProjectFolderPath}");

            }
            catch (Exception ex)
            {
                AlertAndLog($"GitCommands: Err={ex}");
            }

        }


        static void OpenFolder(string folderPath)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = folderPath,
                UseShellExecute = true,
                Verb = "open"
            });
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dialogAbout dialog = new dialogAbout();
            DialogResult result = dialog.ShowDialog();
        }

        private void comboGitCommands_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonGetCurrentProjectionInfo_Click(object sender, EventArgs e)
        {
            try
            {
                ISimioProject currentProject = SimioContext.ActiveProject;

                if (currentProject == null)
                {
                    AlertAndLog("No project is currently open.");
                    return;
                }   

                Logit($"Current Project={GitHelperContext.SimioProjectName}. FullPath={GitHelperContext.ProjectFolderPath}");

            }
            catch (Exception ex)
            {
                AlertAndLog($"Cannot get current project. Err={ex.Message}");
            }
        }

        private void buttonLaunchVSCode_Click(object sender, EventArgs e)
        {
            string simioProjectFolder = ProjectFolderPath;
            string vsCodePath = GitHelpers.FindVSCodeExecutable();
            Logit($"Launching VSCode. Path to VSCode={vsCodePath}. ProjectFolder={simioProjectFolder}");

            GitHelpers.LaunchVSCode(vsCodePath, simioProjectFolder);
        }

        private void buttonSaveSimioProject_Click(object sender, EventArgs e)
        {
            //ISimioProject project = SimioContext.ActiveProject;
            //project.Save();

        }

        private void buttonCloneSimioProject_Click(object sender, EventArgs e)
        {
            Logit("Cloning project");

            string url = textRemoteUrl.Text;
            string parentPath = textLocalParentFolder.Text;
            string repoName = textLocalRepoName.Text;

            string result = GitHelpers.CloneRepository(url, parentPath, repoName);
            Logit($"Cloning operation complete. Result={result}");
        }


        private void Logit(string message)
        {
            MyLogger.Add(message);
        }
        public void AlertAndLog(string message)
        {
            Logit(message);
            MessageBox.Show(message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonSearchCloneFolder_Click(object sender, EventArgs e)
        {
            try
            {
                string defaultPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "source", "repos");

                // Prompt the user to select a folder
                string localPath = GitHelpers.PromptForFolder(defaultPath);

                if (string.IsNullOrEmpty(localPath))
                {
                    Console.WriteLine("No folder selected. Exiting...");
                    return;
                }

                // Ensure the selected folder exists
                if (!Directory.Exists(localPath))
                {
                    Directory.CreateDirectory(localPath);
                    Logit($"Created parent folder: {localPath}");
                }
                textLocalParentFolder.Text = localPath;
            }
            catch (Exception ex)
            {
                AlertAndLog($"Cannot select local folder. Err={ex.Message}");
            }
        }

        private void buttonUrlPaste_Click(object sender, EventArgs e)
        {
            try
            {
                if (Clipboard.ContainsText())
                {
                    textRemoteUrl.Text = Clipboard.GetText();
                }
            }
            catch (Exception ex)
            {
                AlertAndLog($"Cannot paste URL. Err={ex.Message}");  
            }
        }

        private void buttonLaunchFileExplorer_Click(object sender, EventArgs e)
        {
            try
            {
                Logit($"Launching File Explorer with Folder={this.ProjectFolderPath}");
                OpenFolder(this.ProjectFolderPath);
            }
            catch (Exception ex)
            {
                AlertAndLog($"Cannot launch to Folder={this.ProjectFolderPath}. Err={ex.Message}");
            }
        }

        private void buttonGitStatus_Click(object sender, EventArgs e)
        {
            string result = GitHelpers.ExecuteGitCommand("status");
            string[] lines = result.Split('\n');
            int nn = 1;
            foreach (string line in lines)
            {
                Logit($" {nn++}: {line}");
            }
        }

        private void textLogging_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textLogging.Clear();
        }
    }
}
