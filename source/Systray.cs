using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows;
using System.Windows.Forms;

namespace Steam_Account_Changer
{
    class Systray
    {
        private static NotifyIcon notiIco = new NotifyIcon();
        private static ContextMenu contextMenu = new ContextMenu();

        public static void Init()
        {
            ReloadContextMenu();

            notiIco.Icon = new Icon("./steam.ico");
            notiIco.Text = "Steam Account Changer";
            notiIco.Visible = true;
            notiIco.ContextMenu = contextMenu;

            Application.Run();

            return;
        }

        public static void ReloadContextMenu()
        {
            contextMenu.MenuItems.Clear();
            MenuItem menuItem;
            int cIndex = 0;

            foreach (UserDatabase.User u in UserDatabase.users)
            {
                menuItem = new MenuItem();
                menuItem.Index = cIndex++;
                menuItem.Text = "Log into Account: " + u.alias;
                menuItem.Click += new System.EventHandler(SelectUser);
                contextMenu.MenuItems.Add(menuItem);
            }

            menuItem = new MenuItem();
            menuItem.Index = cIndex++;
            menuItem.Text = "Reload account list";
            menuItem.Click += new System.EventHandler(SelectReload);
            contextMenu.MenuItems.Add(menuItem);

            menuItem = new MenuItem();
            menuItem.Index = cIndex++;
            menuItem.Text = "About";
            menuItem.Click += new System.EventHandler(SelectAbout);
            contextMenu.MenuItems.Add(menuItem);

            menuItem = new MenuItem();
            menuItem.Index = cIndex++;
            menuItem.Text = "Quit";
            menuItem.Click += new System.EventHandler(SelectQuit);
            contextMenu.MenuItems.Add(menuItem);

            return;
        }


        private static void SelectQuit(Object sender, EventArgs e)
        {
            System.Environment.Exit(0);

            return;
        }
        private static void SelectAbout(Object sender, EventArgs e)
        {
            MessageBox.Show("Steam Account Changer\nAuthor: Leon Etienne\nVersion: v1.0\nThanks for using!\n\nMay Gaben be with you. Amen.",
                            "About Steam Account Changer",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            return;
        }

        private static void SelectReload(Object sender, EventArgs e)
        {
            UserDatabase.ReloadUsers();
            ReloadContextMenu();

            return;
        }

        private static void SelectUser(Object sender, EventArgs e)
        {
            UserDatabase.User user = UserDatabase.users[((MenuItem)sender).Index];

            SteamInterface.Login(user);

            return;
        }
    }
}
