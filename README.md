# Boot2Parsec
A set of tools to configure a fresh Windows installation to only run Parsec.
I decided to create this because on older devices and especially on Windows 11 the system is resource intensive which takes away from Parsec's performance.

# Running
1. Build the installer and program, or download from [the releases](https://github.com/kattschan/Boot2Parsec/releases)
2. Run the installer. As mentioned in the releases, it will not prompt you again after asking for privileges about whether you want to install or not. Please be sure.
3. Restart your device
4. That's it! You can access the minimized window in the bottom left for a few system functions or restarting the app if it closes.

# Building
This is a Windows Forms app because I wanted to try out making one. Clone the repo and open it in Visual Studio (I have 2022). Change what you like then build it from the controls at the top.

# Future ideas
I would like to implement network control (i.e. a trigger for the network flyout) and other missing system functions in a future release.
