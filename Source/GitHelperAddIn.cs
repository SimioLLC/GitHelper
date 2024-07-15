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
                if (context.ActiveProject == null)
                {
                    AlertLog("You must have an active project to run this add-in.");
                }
                if (context.ActiveModel == null)
                {
                    AlertLog("You must have an active model to run this add-in.");
                }

                IModel am = context.ActiveModel;

                StringBuilder sb = new StringBuilder();

                // Get the full path to the project file

                string filepath = GitHelpers.GetStringProperty(context.ActiveProject, "FileName");
                if ( string.IsNullOrEmpty(filepath))
                {
                    AlertLog($"No filepath found for ActiveProject. Please provide a Simio project that has been saved to a file.");
                }

                // Find the folder that contains the project file
                string filename = Path.GetFileName(filepath);


                string extension = Path.GetExtension(filepath);
                if ( extension.ToLower() != ".simproj")
                {
                    AlertLog($"The Simio project must be converted to a .simproj file.  Found {extension} instead.");
                }


                // Check for folder expectations
                string folder = Path.GetDirectoryName(filepath);

                string gitFolder = Path.Combine(folder, ".git");
                if (!Directory.Exists(gitFolder))
                {
                    AlertLog($"No .git folder found in {folder}. Please set up Git on the Simio project folder.");
                }

                // Launch the form and give it access to the Simio Design Context
                FormGitHelper FormViewer = new FormGitHelper
                {
                    SimioContext = context,
                    MyLogger = logger
                };

                FormViewer.Show();

            }
            catch (Exception ex)
            {
                if (ex.Message != "Canceled")
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }



        internal void Logit(string message)
        {
            logger.Add(message);

        }

        private void AlertLog(string message)
        {
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
