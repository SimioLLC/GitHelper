// VisioUtility.cs
// compile with: /doc:VisioUtility.xml
// <copyright>Copyright (c) Microsoft Corporation. All rights reserved.
// </copyright>
// <summary>This file contains utility classes and methods that perform
// operations commonly performed on Visio objects.</summary>

using System.Diagnostics;
using System.Windows.Forms;

namespace GitHelperAddIn
{
    using System;
    using System.IO;
    using System.Reflection;
    using System.Runtime.Versioning;

    public static class GitHelpers
    {

        public static string GetTargetFrameworkForExecutable(string assemblyPath)
        {
            if (!File.Exists(assemblyPath))
            {
                return $"Please provide the path to the assembly. {assemblyPath} doesn't work.";
            }

            try
            {
                Assembly assembly = Assembly.LoadFrom(assemblyPath);
                var targetFrameworkAttribute = assembly
                    .GetCustomAttribute<TargetFrameworkAttribute>();

                if (targetFrameworkAttribute != null)
                {
                    return $"{targetFrameworkAttribute.FrameworkName}";
                }
                else
                {
                    return $"?Target Framework attribute not found: {assemblyPath}";
                }
            }
            catch (Exception ex)
            {
                return $"?Exception:{ex.Message}";
            }
        }

        /// <summary>
        /// Launch Visual Studio Code with the specified folder path.
        /// </summary>
        /// <param name="folderPath"></param>
        public static void LaunchVSCode(string folderPath)
        {
            var processStartInfo = new System.Diagnostics.ProcessStartInfo
            {
                FileName = "code",
                Arguments = $"\"{folderPath}\"",
                UseShellExecute = true,
                CreateNoWindow = true
            };

            System.Diagnostics.Process.Start(processStartInfo);
        }

        /// <summary>
        /// Find where VSCode is located
        /// </summary>
        /// <returns></returns>
        public static string FindVSCode()
        {
            try
            {
                // Create a process to run the 'where' command
                ProcessStartInfo processInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = "/c where code",
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                Process process = Process.Start(processInfo);
                process.WaitForExit();

                // Look for a code.cmd or code.exe file, and return the output
                string output = process.StandardOutput.ReadToEnd().Trim();

                if (!string.IsNullOrEmpty(output))
                {
                    output = output.Replace("\r\n", "\n");
                    output = output.Split('\n')[0].Trim();
                    string folderPath = Path.GetDirectoryName(output);
                    foreach (string file in Directory.GetFiles(folderPath))
                    {
                        string filename = Path.GetFileNameWithoutExtension(file).ToLower();
                        string extension = Path.GetExtension(file).ToLower();
                        if ( filename == "code" 
                            && (extension == ".cmd" || extension == ".exe"))
                        {
                            return file;
                        }

                    }
                    return $"?No launchable file found in folder={folderPath}";
                }
                else
                {
                    return "?VSCode not found in PATH.";
                }
            }
            catch (Exception ex)
            {
                return $"?Error finding VSCode: {ex.Message}";
            }
        }

        /// <summary>
        /// Launch Visual Studio Code with the specified folder path.
        /// </summary>
        /// <returns></returns>
        public static string LaunchVSCode(string vscodePath, string targetPath)
        {
            try
            {
                string extension = Path.GetExtension(vscodePath).ToLower();
                string folderPath = targetPath.Replace(@"\", "/");

                ProcessStartInfo processInfo;

                if (extension == ".exe")
                {
                    processInfo = new ProcessStartInfo
                    {
                        FileName = vscodePath,
                        Arguments = $"--new-window \"{folderPath}\"",
                        RedirectStandardOutput = true,
                        UseShellExecute = false,
                        CreateNoWindow = false
                    };
                }
                else if (extension == ".cmd")
                {
                    processInfo = new ProcessStartInfo
                    {
                        FileName = "cmd.exe",
                        Arguments = $"/c \"{vscodePath}\" \"{folderPath}\"",
                        RedirectStandardOutput = true,
                        UseShellExecute = false,
                        CreateNoWindow = false
                    };

                }
                else
                {
                    return $"?VSCode path must be a .cmd or .exe file. Found {extension} instead.";
                }

                try
                {
                    Process process = Process.Start(processInfo);
                    return $"VSCode started with {targetPath}";
                }
                catch (Exception ex)
                {
                    return $"VSCode start failed with {targetPath}. Err={ex.Message}";
                }
            }
            catch (Exception ex)
            {
                return $"?Error Launching VSCode: {ex.Message}";
            }
        }


        static string ExecuteGitCommand(string gitCommand )
        {

            ProcessStartInfo processInfo = new ProcessStartInfo
            {
                FileName = "git",
                Arguments = $"{gitCommand}",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true
            };

            try
            {
                using (Process process = Process.Start(processInfo))
                {
                    string output = process.StandardOutput.ReadToEnd();
                    string error = process.StandardError.ReadToEnd();
                    process.WaitForExit();

                    if (process.ExitCode == 0)
                    {
                        return $"Git output:{output}";
                    }
                    else
                    {
                        return $"?Git error: {error}";
                    }
                }
            }
            catch (Exception ex)
            {
                return $"Failed to clone repository: {ex.Message}";
            }
        }

        /// <summary>
        /// Prompt the user to select a parent folder for the repository.
        /// </summary>
        /// <param name="defaultPath"></param>
        /// <returns></returns>
        public static string PromptForFolder(string defaultPath)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Select the parent folder under which you want to clone the repository";
                folderDialog.SelectedPath = defaultPath;
                folderDialog.ShowNewFolderButton = true;

                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    return folderDialog.SelectedPath;
                }
            }

            return null;
        }

        /// <summary>
        /// Clone a Simio Project repository from the specified URL to the local path.
        /// </summary>
        /// <param name="repoUrl"></param>
        /// <param name="localParentPath"></param>
        /// <returns></returns>
        public static string CloneRepository(string repoUrl, string localParentPath, string repoName)
        {
            // Create a new process to run the git clone command
            localParentPath = localParentPath.Replace(@"\", "/");

            // Do some housekeeping. We want the localParentPath to already exist, but
            // the repoName (subdirectory) should not exist.
            if (Directory.Exists(localParentPath))
            {
                string repoPath = Path.Combine(localParentPath, repoName);
                if (Directory.Exists(repoPath))
                {
                    return $"?The repository {repoName} already exists in {localParentPath}";
                }
            }
            else
            {
                return $"?The parent path {localParentPath} does not exist. Please create it and try again.";
            }

            string localFullpath = Path.Combine(localParentPath, repoName);
            if ( Directory.Exists(localFullpath))
            {
                return $"?The repository {repoName} already exists in {localFullpath}";
            }

            localFullpath = localFullpath.Replace(@"\", "/");

            ProcessStartInfo processInfo = new ProcessStartInfo
            {
                FileName = "git",
                Arguments = $"clone {repoUrl} \"{localFullpath}\"",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true
            };

            try
            {
                using (Process process = Process.Start(processInfo))
                {
                    string output = process.StandardOutput.ReadToEnd();
                    string error = process.StandardError.ReadToEnd();
                    process.WaitForExit();

                    if (process.ExitCode == 0)
                    {
                        return $"Git success: Repository cloned successfully.";
                    }
                    else
                    {
                        return $"?Git error: {error}";
                    }
                }
            }
            catch (Exception ex)
            {
                return $"?Git error: Failed to clone repository: {ex.Message}";
            }
        }

        public static string FindVSCodeExecutable()
        {
            // Define common possible VSCode installation paths
            string[] possiblePaths = new string[]
            {
            @"Microsoft VS Code\Code.exe",
            @"Microsoft VS Code\bin\code.cmd",
            @"Microsoft VS Code\bin\code",
            };

            // Search through all logical drives
            foreach (var drive in DriveInfo.GetDrives())
            {
                if (drive.DriveType == DriveType.Fixed) // Only check fixed drives
                {
                    foreach (var path in possiblePaths)
                    {
                        string fullPath = Path.Combine(drive.Name, "Program Files", path);
                        if (File.Exists(fullPath))
                        {
                            return fullPath;
                        }

                        fullPath = Path.Combine(drive.Name, "Program Files (x86)", path);
                        if (File.Exists(fullPath))
                        {
                            return fullPath;
                        }

                        fullPath = Path.Combine(drive.Name, "Users", Environment.UserName, "AppData", "Local", "Programs", path);
                        if (File.Exists(fullPath))
                        {
                            return fullPath;
                        }
                    }
                }
            }

            return null;
        }


        /// <summary>
        /// Use reflection to get a string value.
        /// The name must be an exact match, and known to be string.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        internal static string GetStringProperty(Object obj, string propertyName)
        {
            try
            {
                foreach (PropertyInfo pi in obj.GetType().GetProperties())
                {
                    var getter = pi.GetGetMethod();
                    if (getter.ReturnType.IsArray)
                    {
                        // Not using this now.
                    }
                    else
                    {
                        if (pi.Name == propertyName)
                        {
                            var vv = pi.GetValue(obj, null);
                            return (vv ?? "").ToString();
                        }
                    }

                }
                return string.Empty;

            }
            catch (Exception)
            {
                return string.Empty;
            }
        }


    }
}

