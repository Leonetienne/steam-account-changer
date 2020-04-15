using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

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
            users = JsonConvert.DeserializeObject<List<User>>(File.ReadAllText("./accounts.json"));

            return;
        }
    }
}
