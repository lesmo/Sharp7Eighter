using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;
using System.Threading;
using System.Diagnostics;

namespace Sharp7Eigther {
    static class Program {
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        static bool IsNewInstance;
        static Mutex Mutex;
        static Main MainForm = null;
        
        public static string UpdateWPUrl = System.Environment.CurrentDirectory;

        public static DefaultTraceListener LogWriter = new DefaultTraceListener() {
            LogFileName = Environment.CurrentDirectory + @"\Sharp7Eighter.log"
        };

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Mutex = new Mutex(true, "Sharp7Eigther", out IsNewInstance);

            if ( IsNewInstance ) {
                UpdateWPUrl += (Helpers.IsX64()
                               ? Properties.Settings.Default.UpdateWPx64
                               : Properties.Settings.Default.UpdateWPx86);

                Application.EnableVisualStyles();

                LogWriter.WriteLine("");
                LogWriter.WriteLine("[Tool session started at " + DateTime.UtcNow + "]");

                MainForm = new Main();
                Application.Run(MainForm);
            } else {
                Process current = Process.GetCurrentProcess();
                foreach ( Process process in Process.GetProcessesByName(current.ProcessName) ) {
                    if ( process.Id != current.Id ) {
                        SetForegroundWindow(process.MainWindowHandle);
                        break;
                    }
                }
            }
        }
    }
}
