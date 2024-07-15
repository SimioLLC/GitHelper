// VisioUtility.cs
// compile with: /doc:VisioUtility.xml
// <copyright>Copyright (c) Microsoft Corporation. All rights reserved.
// </copyright>
// <summary>This file contains utility classes and methods that perform
// operations commonly performed on Visio objects.</summary>

namespace GitHelperAddIn
{
    using System.IO;

    public class GitHelperContext
    {
        /// <summary>
        /// The full path to the parent folder under which the project folder will be created.
        /// It must exist.
        /// </summary>
        public string ParentFolderPath { get; set; }

        /// <summary>
        /// The project file name is the name of the project file.
        /// It consists of a valid filename and a .simproj extension
        /// It may not exist until the project is cloned. 
        /// </summary>
        public string ProjectFileName
        {
            get
            {
                if (string.IsNullOrEmpty(ProjectFolderPath))
                    return string.Empty;

                return Path.Combine(ProjectFolderPath, $"{SimioProjectName}.simproj");
            }
        }

        /// <summary>
        /// The Project folder path is the combination of the parent folder and the project folder name.
        /// It may not exist until the project is cloned.
        /// </summary>
        public string ProjectFolderPath
        {
            get
            {
                if (string.IsNullOrEmpty(ParentFolderPath))
                    return string.Empty;
                if (string.IsNullOrEmpty(SimioProjectName))
                    return string.Empty;

                return Path.Combine(ParentFolderPath, SimioProjectName);
            }
        }
            

        /// <summary>
        /// The name of the Simio project without the .simproj extension.
        /// </summary>
        public string SimioProjectName { get; set; }


    }
}

