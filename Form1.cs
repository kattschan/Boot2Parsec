using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsB2PShell
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool ExitWindowsEx(uint uFlags, uint dwReason);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool LockWorkStation();

        private const int SW_MAXIMIZE = 3;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        public Form1()
        {
            InitializeComponent();
            Process.Start("C:\\Program Files\\Parsec\\parsecd.exe");
            CheckParsecdStatus();
            this.WindowState = FormWindowState.Minimized;
        }

        private async void CheckParsecdStatus()
        {
            while (true)
            {
                if (IsParsecdRunning())
                {
                    launcherButton.Enabled = false;
                    launcherButton.Text = "Parsec is running";
                }
                else
                {
                    launcherButton.Enabled = true;
                    launcherButton.Text = "Relaunch";
                }
                await Task.Delay(1000); // Check every second
            }
        }

        private bool IsParsecdRunning()
        {
            return Process.GetProcessesByName("parsecd").Length > 0;
        }

        private void launcherButton_Click(object sender, EventArgs e)
        {
            if (!IsParsecdRunning())
            {
                Process.Start("C:\\Program Files\\Parsec\\parsecd.exe");
            }
        }

        private void logOff_Click(object sender, EventArgs e)
        {
            // Show a confirmation dialog
            DialogResult result = MessageBox.Show(
                "Are you sure you want to log off?",
                "Confirm Log Off",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            // Check the user's response
            if (result == DialogResult.Yes)
            {
                // Log off the user
                ExitWindowsEx(0, 0); // EWX_LOGOFF = 0
            }
            else
            {
                // Continue execution (do nothing)
            }
        }

        private void lockButton_Click(object sender, EventArgs e)
        {
            LockWorkStation();
        }

        private void shutDown_Click(object sender, EventArgs e)
        {
            var psi = new ProcessStartInfo("shutdown", "/s /t 0");
            psi.CreateNoWindow = true;
            psi.UseShellExecute = false;
            Process.Start(psi);
        }
    }
}
