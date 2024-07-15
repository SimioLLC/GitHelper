using SimioAPI;
using SimioAPI.Extensions;
using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace GitHelperAddIn
{
    /// <summary>
    /// History:
    /// An AddIn for using Git with Simio.
    /// {Jul2024/dHouck} Creation.
    /// </summary>
    public class GitHelperAddIn : IDesignAddIn, IDesignAddInGuiDetails
    {        

        internal static ISimioProject CurrentProject { get; set; }

        internal static GitHelperContext GitContext { get; set; } = new GitHelperContext();

        internal static Logger logger = new Logger();

        #region IDesignAddIn Members

        /// <summary>
        /// Property returning the name of the add-in. This name may contain any characters and is used as the display name for the add-in in the UI.
        /// </summary>
        public string Name
        {
            get { return "Git Helper"; }
        }

        /// <summary>
        /// Property returning a short description of what the add-in does.  
        /// </summary>
        public string Description
        {
            get { return "This addin Provides assistance for using Git with Simio"; }
        }
        
        /// <summary>
        /// Property returning an icon to display for the add-in in the UI.
        /// </summary>
        public Image Icon
        {
            get { return Properties.Resources.IconPng; }
        }

        #endregion

        /// <summary>
        /// Method called when the add-in is run.
        /// </summary>
        public void Execute(IDesignContext context)
        {

            try
            {
                // Check to make sure a model has been opened in Simio
                string projectFileName = GitHelpers.GetStringProperty(context.ActiveProject, "FileName");
                if ( string.IsNullOrEmpty(projectFileName))
                {
                    string message = "There is no active project file. Enter the Parent folder under which the Simio Project folder will reside.";
                    GitContext.ParentFolderPath = GetFolderPath(message);
                    if ( !Directory.Exists(GitContext.ParentFolderPath))
                    {
                        AlertLog($"The folder {GitContext.ParentFolderPath} does not exist.  Please create it and try again.");
                        return;
                    }
                    // See if it has children
                    if (Directory.GetDirectories(GitContext.ParentFolderPath).Length == 1)
                    {
                        string childPath = Directory.GetDirectories(GitContext.ParentFolderPath)[0];
                        GitContext.SimioProjectName = GitHelpers.GetLastFolderName(childPath);
                        AlertLog($"The parent folder has one Child, which is assumed to be the Simio Project={GitContext.SimioProjectName}");
                    }
                    else
                    {
                        GitContext.SimioProjectName = string.Empty;
                    }
                }
                else // We found the name in the file.
                {
                    string fullProjectFilePath = GitHelpers.GetStringProperty(context.ActiveProject, "FileName");
                    string folderPath = Path.GetDirectoryName(fullProjectFilePath);
                    GitContext.ParentFolderPath = GitHelpers.GetParentFolderFullPath(folderPath);
                    GitContext.SimioProjectName = GitHelpers.GetLastFolderName(folderPath);
                }

                StringBuilder sb = new StringBuilder();

                // Check for folder expectations

                if (Directory.Exists(GitContext.ProjectFolderPath))
                {
                    string gitFolder = Path.Combine(GitContext.ProjectFolderPath, ".git");
                    if (!Directory.Exists(gitFolder))
                    {
                        AlertLog($"No .git folder ({gitFolder}). Please set up Git on the Simio project folder.");
                        goto ShowForm;
                    }
                }

            }
            catch (Exception ex)
            {
                if (ex.Message != "Canceled")
                {
                    MessageBox.Show(ex.Message, "Execute Error");
                }
            }

        ShowForm:

            // Launch the form and give it access to the Simio Design and Git Contexts
            FormGitHelper FormViewer = new FormGitHelper
            {
                SimioContext = context,
                GitHelperContext = GitContext,
                MyLogger = logger
            };

            FormViewer.Show();
        }

        private string GetFolderPath(string message)
        {
            string selectedPath = string.Empty;

            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = message;
                folderBrowserDialog.ShowNewFolderButton = true;

                // Show the dialog and get the result
                DialogResult result = folderBrowserDialog.ShowDialog();

                // Check if the user selected a folder
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                {
                    selectedPath = folderBrowserDialog.SelectedPath;
                    // Display the selected folder path
                    Logit($"Selected folder: {selectedPath}");
                }
                else
                {
                    // Display a message if no folder was selected
                    Logit("No folder selected.");
                }
                return selectedPath;
            }
        }

        private string GetFilePath()
        {
            string selectedPath = string.Empty;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Simproj files (*.simproj)|*.simproj";
                openFileDialog.Title = "Select a .simproj file";

                // Show the dialog and get the result
                DialogResult result = openFileDialog.ShowDialog();

                // Check if the user selected a file
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(openFileDialog.FileName))
                {
                    selectedPath = openFileDialog.FileName;
                    // Display the selected file path
                    Logit($"Selected file={selectedPath}");
                }
                else
                {
                    // Display a message if no file was selected
                    Logit($"No file selected.");
                }
                return selectedPath;
            }
        }

        internal void Logit(string message)
        {
            logger.Add(message);

        }

        private void AlertLog(string message)
        {
            MessageBox.Show(message, "Alert");
            logger.Add(message);
        }
    

    #region IDesignAddInGuiDetails Members

    // Here is a sample implementation of the optional IDesignAddInGuiDetails interface.
    // To use this implementation, un-comment the interface name on the "class" line at
    // the top of this file.
    //
    // If a design-time add-in implements this optional interface, it can specify where
    // in Simio's ribbon area it should appear.  Merely implementing the interface, and
    // returning null for CategoryName, TabName, and GroupName will cause the add-in to
    // appear at a default location defined by Simio.  However, the add-in can return a
    // specific name for any or all of these properties, to indicate where it should be
    // located in Simio's ribbon area.

    /// <summary>
    /// Property returning the category name for this Add-In.  Return null to use Simio's default add-in category name.
    /// </summary>
    public string CategoryName
    {
        get { return "Developer Tools"; }
    }

    /// <summary>
    /// Property returning the group name for this Add-In.  Return null to use Simio's default add-in group name.
    /// </summary>
    public string GroupName
    {
        get { return "Git"; }
    }

    /// <summary>
    /// Property returning the tab name for this Add-In.  Return null to use Simio's default add-in tab name.
    /// </summary>
    public string TabName
    {
        get { return "Git Helpers"; }
    }

    #endregion
}

}
