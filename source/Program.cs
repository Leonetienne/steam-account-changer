using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Steam_Account_Changer
{
    class Program
    {
        [DllImport("kernel32.dll")]
        static extern bool FreeConsole();


        static void Main(string[] args)
        {
            FreeConsole();

            Settings.Init();
            UserDatabase.Init();
            Systray.Init();


            return;
        }
    }
}
