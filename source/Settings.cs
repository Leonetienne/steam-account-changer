using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Steam_Account_Changer
{
    class Settings
    {
        public static string steamPath;
        
        public static void Init()
        {
            if ((File.Exists("./steampath.cfg")) && (new FileInfo("./steampath.cfg").Length > 0))
            {
                steamPath = File.ReadAllText("./steampath.cfg");
            }
            else
            {
                StreamWriter sw = File.CreateText("./steampath.cfg");
                sw.Write("C:\\Program Files (x86)\\Steam\\steam.exe");
                steamPath = "C:\\Program Files (x86)\\Steam\\steam.exe";

                MessageBox.Show("Steam Account Changer is missing the config file \"steampath.cfg\".\nIt got created with the default value:\nC:\\Program Files (x86)\\Steam\\steam.exe",
                            "About Steam Account Changer",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            }

            return;
        }
    }
}
