using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;

namespace Sharp7Eigther.Steps {
    public partial class Step2 : UserControl {
        public event EventHandler OnNextStep;
        private Main MainForm;

        delegate void MoveToStep_LeftAnimation_Delegate(UserControl current, UserControl next);
        delegate void MoveToStep_RightAnimation_Delegate(UserControl current, UserControl next);

        MoveToStep_RightAnimation_Delegate AnimateRight_Delegate;
        MoveToStep_LeftAnimation_Delegate AnimateLeft_Delegate;

        public Step2(Main MainForm) {
            InitializeComponent();
            this.MainForm = MainForm;
            this.AnimateRight_Delegate = new MoveToStep_RightAnimation_Delegate(this.MainForm.MoveToStep_RightAnimation);
            this.AnimateLeft_Delegate = new MoveToStep_LeftAnimation_Delegate(this.MainForm.MoveToStep_LeftAnimation);
        }

        public void MainCallback() {
            // Check UpdateWP.exe existance
            if ( !System.IO.File.Exists(Program.UpdateWPUrl) ) {
                this.MainForm.MoveToStep_RightAnimation(this, new Step2f());
                Program.LogWriter.WriteLine("[" + DateTime.UtcNow + "] UpdateWP.exe not found");
                return;
            }

            // Initialize the call to UpdateWP.exe
            Process wpUpdate = new Process();
            wpUpdate.StartInfo = new ProcessStartInfo() {
                FileName = Program.UpdateWPUrl,
                Arguments = "/iu sharpdnm",
                RedirectStandardOutput = true,
                UseShellExecute = false,
                WindowStyle = ProcessWindowStyle.Hidden,
                CreateNoWindow = true
            };

            // Call UpdateWP and wait for it to close
            wpUpdate.EnableRaisingEvents = true;
            wpUpdate.Exited += wpUpdate_Exited;
            wpUpdate.Start();
        }

        void wpUpdate_Exited(object sender_wpUpdate, EventArgs e_wpUpdate) {
            Process wpUpdate = (Process)sender_wpUpdate;
            string wpUpdateOutput = wpUpdate.StandardOutput.ReadToEnd();

            if ( wpUpdateOutput.Contains("Zune is currently running") ) {
                // Show Zune Running error
                Step2z Step2z = new Step2z();
                Step2z.OnPrevStep += (object sender, EventArgs e) => {
                    this.MainForm.MoveToStep_LeftAnimation((UserControl)sender, this);
                    this.MainCallback();
                };

                Program.LogWriter.WriteLine("[" + DateTime.UtcNow + "] Zune.exe is currently running");
                this.MainForm.Invoke(this.AnimateRight_Delegate, new object[] { this, Step2z });
            } else if ( wpUpdateOutput.Contains("COM") ) {
                // Show Windows Phone Support Tools not installed error
                Step2c Step2c = new Step2c();
                Step2c.OnPrevStep += (object sender, EventArgs e) => {
                    this.MainForm.MoveToStep_LeftAnimation((UserControl)sender, this);
                    this.MainCallback();
                };

                Program.LogWriter.WriteLine("[" + DateTime.UtcNow + "] Windows Phone Support Tools not found (COM error): \n" + wpUpdateOutput);
                this.MainForm.Invoke(this.AnimateRight_Delegate, new object[] { this, Step2c });
            } else if ( wpUpdateOutput.Contains("devices were found") ) {
                // Show no devices found error
                Step2d Step2d = new Step2d();
                Step2d.OnPrevStep += (object sender, EventArgs e) => {
                    this.MainForm.MoveToStep_LeftAnimation((UserControl)sender, this);
                    this.MainCallback();
                };

                Program.LogWriter.WriteLine("[" + DateTime.UtcNow + "] UpdateWP.exe found no devices to update");
                this.MainForm.Invoke(this.AnimateRight_Delegate, new object[] { this, Step2d });
            } else if ( wpUpdateOutput.Contains("Applying update") ) {
                // Parse data for device
                Helpers.ParseUpdateWpOutput(wpUpdateOutput);

                // Go to next step
                Program.LogWriter.WriteLine("[" + DateTime.UtcNow + "] Environment check completed, everything OK");
                this.MainForm.Invoke(OnNextStep);
            } else {
                // Show errors
                Step2e Step2e = new Step2e(wpUpdateOutput);
                Step2e.OnPrevStep += (object sender, EventArgs e) => {
                    this.MainForm.MoveToStep_LeftAnimation((UserControl)sender, this);
                    this.MainCallback();
                };

                Program.LogWriter.WriteLine("[" + DateTime.UtcNow + "] An unexpected output from UpdateWP.exe has ocurred: \n" + wpUpdateOutput);
                this.MainForm.Invoke(this.AnimateRight_Delegate, new object[] { this, Step2e });
            }
        }
    }
}
