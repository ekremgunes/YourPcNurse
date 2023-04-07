using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace YourPcNurse
{
    internal static class Program
    {
        static class NativeMethods
        {
            [DllImport("user32.dll")]
            internal static extern bool SetForegroundWindow(IntPtr hWnd);
        }

        [STAThread]
        static void Main()
        {
            // if user openned this before ,show active app else create one 
            Process currentProcess = Process.GetCurrentProcess();
            Process[] processes = Process.GetProcessesByName(currentProcess.ProcessName);

            if (processes.Length > 1)
            {
                foreach (Process process in processes)
                {
                    
                    if (process.Id != currentProcess.Id && process.MainModule.FileName == currentProcess.MainModule.FileName)
                    {
                        //get active form
                        var yourPcNurse = (YourPcNurse)Application.OpenForms["YourPcNurse"];
                        //show  on top
                        yourPcNurse.Show();
                        NativeMethods.SetForegroundWindow(process.MainWindowHandle);
                        break;
                    }
                }
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new YourPcNurse());
            }
        }
    }
}
