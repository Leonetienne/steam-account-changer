# Steam Account Changer

This is my simple steam account changer that allows you to switch steam accounts with just 2 clicks!

If you won't trust me with your password, which you should NOT, compile it yourself, the source is in /source.  
If you are too lazy or just don't know how to, you can download the compiled version from /binaries.

Just modify the accounts.json to fit your accounts, and you're good to go!  
The field `alias` is the username shown in the systray,  
The field `username` is the username used for login and the field `password` is the password used for logging in.

Use taskmanager or some other utility to start the .exe on startup and right-click it's icon (slightly brighter steam icon) in the systray to select an account to log in to!
It's that simple!  


If you have steam installed somewhere else, you can modify the path in `steampath.cfg`.


Tutorial video (german voiceover only)
https://youtu.be/2sSnsNbmoyw






Special thanks to Newtonsoft for creating this awesome json nuget package and for Valve for giving steam command line arguments, which this program is using.