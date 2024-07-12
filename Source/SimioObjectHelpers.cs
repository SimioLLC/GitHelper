using SimioAPI;
using SimioAPI.Extensions;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitHelperAddIn
{
    public static class SimioObjectHelpers
    {

        public static string ConvertToName(string suggestedName)
        {
            string name = suggestedName;
            do
            {
                name = name.Replace(" ", "");
                name = name.Replace(",", "_");

            } while (name.IndexOf(' ') != -1 && (name.IndexOf(',') != -1));

            // If it is an integer, then assume a zip code an prefix "Zip"
            int nn;
            if (int.TryParse(name, out nn))
            {
                name = $"Zip{name}";
            }

            return name;
        }

    }
}
