using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ShellBrute7kb
{
    public class ReadPwdFile
    {
        public static string[] ReadFile()
        {
            List<string> lines = new List<string>();
            using (StreamReader reader = new StreamReader(Path.Combine(Application.StartupPath, "pwd.txt")))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    lines.Add(line);
                }
            }
            return lines.ToArray();
        }
    }
}
