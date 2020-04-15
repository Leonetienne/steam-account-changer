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
                File.WriteAllText("./steampath.cfg", "C:\\Program Files (x86)\\Steam\\steam.exe");
                steamPath = "C:\\Program Files (x86)\\Steam\\steam.exe";
            }

            return;
        }
    }
}
