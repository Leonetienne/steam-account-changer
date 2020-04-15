using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace Steam_Account_Changer
{
    class UserDatabase
    {
        public class User
        {
            public string alias;
            public string username;
            public string password;
        }

        public static List<User> users;

        public static void Init()
        {
            ReloadUsers();

            return;
        }

        public static void ReloadUsers()
        {
            string json = File.ReadAllText("./accounts.json");

            try
            {
                users = JsonConvert.DeserializeObject<List<User>>(json);
            }
            catch (JsonException e)
            {
                MessageBox.Show("Fatal error: Unable to parse accounts.json!\nDid you mess up the json format?\nTipp: Use a jsonlinter for debugging. Just google for jsonlint",
                                "Can't parse accounts.json",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                System.Environment.Exit(0);
            }

            return;
        }
    }
}
