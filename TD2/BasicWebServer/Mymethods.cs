using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWebServer
{
    class Mymethods
    {
        public string mymethod(string param1, string param2)
        {
            return "<HTML><BODY> Hello " + param1 + " et " + param2 + "</BODY></HTML>";
        }

        public string mymethodexternal(String param1, String param2)
        {
            //
            // Set up the process with the ProcessStartInfo class.
            // https://www.dotnetperls.com/process
            //
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = @"C:\Users\Alexandre MAZURIER\Documents\Documents Cours\Polytech\SI4\Soc-WS\TD2\External_Question5\bin\Debug\External_Question5.exe"; // Specify exe name.
            start.Arguments = param1 + " " + param2; // Specify arguments.
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            //
            // Start the process.
            //
            using (Process process = Process.Start(start))
            {
                //
                // Read in all the text from the process with the StreamReader.
                //
                using (StreamReader reader = process.StandardOutput)
                {
                    string result = reader.ReadToEnd();
                    return result;
                }
            }
        }
    }
}
