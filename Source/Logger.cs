// VisioUtility.cs
// compile with: /doc:VisioUtility.xml
// <copyright>Copyright (c) Microsoft Corporation. All rights reserved.
// </copyright>
// <summary>This file contains utility classes and methods that perform
// operations commonly performed on Visio objects.</summary>

namespace GitHelperAddIn
{
    using System;
    using System.Text;

    public class Logger
    {
        private StringBuilder _sbLogs = new StringBuilder();

        public Logger()
        {
            _sbLogs = new StringBuilder();
        }

        public event Action<string> OnUpdate;

        public void Add(string message)
        {
            _sbLogs.AppendLine($"{DateTime.Now:hh:mm:ss.fff}: {message}");
            OnUpdate?.Invoke(message);
        }

        public void Clear()
        {
            _sbLogs.Clear();
        }

        public string GetLogs()
        {
            return _sbLogs.ToString();
        }   
    }
}

