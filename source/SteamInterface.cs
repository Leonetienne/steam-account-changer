using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Steam_Account_Changer
{
    class SteamInterface
    {
        public static void Login(UserDatabase.User user)
        {
            if (IsSteamRunning())
            {
                StopSteam();
            }

            System.Threading.Thread.Sleep(2000);

            StartSteamWithArguments("-login \"" + user.username + "\" \"" + user.password + "\"");

            return;
        }

        private static void StopSteam()
        {
            StartSteamWithArguments("-shutdown");

            return;
        }

        private static void StartSteamWithArguments(string arguments)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = Settings.steamPath;
            startInfo.Arguments = arguments;
            Process.Start(startInfo);

            return;
        }

        private static bool IsSteamRunning()
        {
            return (Process.GetProcessesByName("Steam").Length > 0);
        }
    }
}
