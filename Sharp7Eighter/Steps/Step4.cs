using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Threading;
using Sharp7Eigther.Properties;

namespace Sharp7Eigther.Steps {
    internal struct updateChainItem {
        public int extraParts;
        public string name;
        public string revision;
    }

    public partial class Step4 : UserControl {
        public event EventHandler OnNextStep;

        private Queue<updateChainItem> updateChain = new Queue<updateChainItem>();
        private ArrayList langSelectedIndexes;
        private Main MainForm;

        private int totalChainItems;

        public Step4(Main MainForm, ArrayList langSelectedIndexes) {
            InitializeComponent();

            this.langSelectedIndexes = langSelectedIndexes;
            this.MainForm = MainForm;

            this.MainFormToggleCloseDelegateV = new MainFormToggleCloseDelegate(this.MainFormToggleClose);

            this.UpdateProgressDelegateV = new UpdateProgressDelegate(this.UpdateProgress);
            this.UpdateTitleDelegateV = new UpdateTitleDelegate(this.UpdateTitle);
            this.UpdateStatusDelegateV = new UpdateStatusDelegate(this.UpdateStatus);

            this.AnimateLeft_Delegate = new MoveToStep_LeftAnimation_Delegate(this.MainForm.MoveToStep_LeftAnimation);
            this.AnimateRight_Delegate = new MoveToStep_RightAnimation_Delegate(this.MainForm.MoveToStep_RightAnimation);
        }

        public void MainCallback() {
            // Load the update chain, and throw error if phone version is not in it
            if ( !this.LoadUpdateChain() ) {
                Program.LogWriter.WriteLine("Phone contains a version not in the update chain");
                this.MainForm.MoveToStep_RightAnimation(this, new Step4w());
                return;
            }

            this.totalChainItems = updateChain.Count();

            // Dequeue previous updates, up to the current version
            updateChainItem chainItem = updateChain.Peek();

            while ( true ) {
                if ( chainItem.revision == DeviceInfo.Revision )
                    break;
                chainItem = updateChain.Dequeue();
            }

            // Create thread
            (new Thread(() => {
                this.MainForm.Invoke(this.MainFormToggleCloseDelegateV);
                this.UpdateNext();
            })).Start();
        }

        private bool LoadUpdateChain() {
            bool isInChain = false;
            foreach ( string chain in Settings.Default.PackagesChain.Split(new char[] {'>'}) ) {
                string[] chainComponents = chain.Split(new char[] { '+', '|' });

                updateChainItem chainItem = new updateChainItem(){
                    extraParts = chainComponents.Length > 2 ? Convert.ToInt32(chainComponents[1]) : 0,
                    name = chainComponents.Length > 2 ? chainComponents[2] : chainComponents[1],
                    revision = chainComponents[0]
                };

                updateChain.Enqueue(chainItem);

                if ( chainItem.revision == DeviceInfo.Revision )
                    isInChain = true;
            }

            return isInChain;
        }

        private void UpdateNext() {
            // Device already has latest update, let's move on
            if ( updateChain.Count == 0 ) {
                Program.LogWriter.WriteLine("Device already has latest update");
                this.MainForm.Invoke(this.MainFormToggleCloseDelegateV);
                this.MainForm.Invoke(this.OnNextStep, new object[] {this, null});
                return;
            }

            float progress = ((float)(this.totalChainItems - updateChain.Count) / this.totalChainItems) * 100;
            this.Invoke(this.UpdateProgressDelegateV, (int)progress);

            // Get the next update available
            updateChainItem chainItem = updateChain.Dequeue();

            // Update UI
            this.Invoke(this.UpdateTitleDelegateV, new string[] { chainItem.name + " (v" + chainItem.revision + ")" });
            this.Invoke(this.UpdateStatusDelegateV, new string[] { "" });

            // Prepare the command argument
            StringCollection revisionPackages = ((StringCollection)Settings.Default["Update" + chainItem.revision]);
            string cmdArg = revisionPackages[0];
            Program.LogWriter.WriteLine("Added URL to queue: " + revisionPackages[0]);
            
            if ( revisionPackages.Count > 1 ) {
                // Load update packages
                if ( revisionPackages.Count > chainItem.extraParts)
                    for ( int i = 0; i < chainItem.extraParts; i++ ) {
                        cmdArg += " " + revisionPackages[i + 1];
                        Program.LogWriter.WriteLine("Added URL to queue: " + revisionPackages[i + 1]);
                    }
                
                // Load language updates
                if ( revisionPackages.Count > chainItem.extraParts + 21 )
                    foreach ( int i in this.langSelectedIndexes ) {
                        cmdArg += " " + revisionPackages[i + chainItem.extraParts + 1];
                        Program.LogWriter.WriteLine("Added URL to queue: " + revisionPackages[i + chainItem.extraParts + 1]);
                    }
            }
            
            // Run the update
            this.RunCommand(cmdArg, chainItem.revision);
        }

        private void RunCommand(string cmdArg, string newRev) {
            Process wpUpdate = new Process();
            wpUpdate.StartInfo = new ProcessStartInfo() {
                FileName = Program.UpdateWPUrl,
                Arguments = "/iu " + cmdArg + (DeviceInfo.Revision == "8773" ? " /enablebackup" : ""),
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                CreateNoWindow = true,
                WindowStyle = ProcessWindowStyle.Hidden,
                UseShellExecute = false,
            };

            wpUpdate.EnableRaisingEvents = true;
            wpUpdate.OutputDataReceived += (object sender, DataReceivedEventArgs e) => {
                if ( e.Data == null ) {
                    return;
                } else if ( e.Data.Contains("Error") ) {
                    this.Invoke(this.UpdateStatusDelegateV, new string[] { e.Data.Trim() + "\n\nRetrying..." });
                    ((Process)sender).Kill();
                    ((Process)sender).Start();
                } else {
                    this.Invoke(this.UpdateStatusDelegateV, new string[] { e.Data.Trim() });
                }
            };
            wpUpdate.Exited += (object sender, EventArgs e) => {
                Process wpUpdate_getDeviceInfo = new Process();
                wpUpdate_getDeviceInfo.StartInfo = new ProcessStartInfo() {
                    FileName = Program.UpdateWPUrl,
                    Arguments = "/iu sharpdnm",
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    WindowStyle = ProcessWindowStyle.Hidden,
                    CreateNoWindow = true
                };
                wpUpdate_getDeviceInfo.Start();
                wpUpdate_getDeviceInfo.WaitForExit();

                string wpUpdateOutput = wpUpdate_getDeviceInfo.StandardOutput.ReadToEnd();
                string prevRevision = DeviceInfo.Revision;

                if ( wpUpdateOutput.Contains("Zune is currently running") ) {
                    // Show Zune Running error
                    Step2z Step2z = new Step2z();
                    Step2z.OnPrevStep += (object sender_step2, EventArgs e_step2) => {
                        this.MainForm.Invoke(this.AnimateLeft_Delegate, new object[] { (UserControl)sender_step2, this });
                        this.RunCommand(cmdArg, newRev);
                    };

                    this.MainForm.Invoke(this.AnimateRight_Delegate, new object[] { this, Step2z });
                } else if ( wpUpdateOutput.Contains("devices were found") ) {
                    // Show no devices found error
                    Step2d Step2d = new Step2d();
                    Step2d.OnPrevStep += (object sender_step2, EventArgs e_step2) => {
                        this.MainForm.Invoke(this.AnimateLeft_Delegate, new object[] { (UserControl)sender_step2, this });
                        this.RunCommand(cmdArg, newRev);
                    };

                    this.MainForm.Invoke(this.AnimateRight_Delegate, new object[] { this, Step2d });
                } else if ( wpUpdateOutput.Contains("Applying update") ) {
                    Helpers.ParseUpdateWpOutput(wpUpdateOutput);

                    if ( DeviceInfo.Revision == prevRevision ) {
                        Step4r Step4e_rev = new Step4r();
                        Step4e_rev.lblError.Text = Step4e_rev.lblError.Text.Replace("%version%", newRev);
                        Step4e_rev.lblErrorDetail.Text = Step4e_rev.lblErrorDetail.Text.Replace("%version%", newRev);
                        Step4e_rev.OnPrevStep += (object sender_s4er, EventArgs e_s4er) => {
                            this.MainForm.Invoke(this.AnimateLeft_Delegate, new object[] { Step4e_rev, this });
                            this.RunCommand(cmdArg, newRev);
                        };

                        this.MainForm.Invoke(this.AnimateRight_Delegate, new object[] { this, Step4e_rev });
                    } else if ( DeviceInfo.Revision != prevRevision ) {
                        this.UpdateNext();
                    } else {
                        Step4w Step4w = new Step4w();
                        Step4w.lblErrorDetail.Text = Step4w.lblErrorDetail.Text.Replace("%version%", DeviceInfo.Revision);

                        this.MainForm.Invoke(this.MainFormToggleCloseDelegateV);
                        this.MainForm.Invoke(this.AnimateRight_Delegate, new object[] { this, new Step4w() });
                        return;
                    }
                } else {
                    // Show errors
                    Step2e Step2e = new Step2e(wpUpdateOutput);
                    Step2e.OnPrevStep += (object sender_step2, EventArgs e_step2) => {
                        this.MainForm.Invoke(this.AnimateLeft_Delegate, new object[] { (UserControl)sender_step2, this });
                        this.RunCommand(cmdArg, newRev);
                    };

                    this.MainForm.Invoke(this.AnimateRight_Delegate, new object[] { this, Step2e });
                }
            };

            wpUpdate.Start();
            wpUpdate.BeginOutputReadLine();
        }

        private delegate void MoveToStep_LeftAnimation_Delegate(UserControl current, UserControl next);
        private MoveToStep_RightAnimation_Delegate AnimateRight_Delegate;

        private delegate void MoveToStep_RightAnimation_Delegate(UserControl current, UserControl next);
        private MoveToStep_LeftAnimation_Delegate AnimateLeft_Delegate;

        private delegate void UpdateProgressDelegate(int progress);
        private UpdateProgressDelegate UpdateProgressDelegateV;
        private void UpdateProgress(int progress) {
            if ( progress > 100 ) progress = 100;
            if ( progress < 0 ) progress = 0;

            this.progressBar.Value = progress;
        }
        
        private delegate void UpdateTitleDelegate(string newTitle);
        private UpdateTitleDelegate UpdateTitleDelegateV;
        private void UpdateTitle(string newTitle) {
            this.lblInstallingUpdate.Text = newTitle.ToUpper();
        }
        private delegate void UpdateStatusDelegate(string newStatus);
        private UpdateStatusDelegate UpdateStatusDelegateV;
        private void UpdateStatus(string newStatus) {
            this.lblStatus.Text = newStatus;
        }

        private delegate void MainFormToggleCloseDelegate();
        private MainFormToggleCloseDelegate MainFormToggleCloseDelegateV;
        private void MainFormToggleClose() {
            this.MainForm.btnClose.Enabled = !this.MainForm.btnClose.Enabled;
            this.MainForm.btnClose.Visible = !this.MainForm.btnClose.Visible;
        }
    }
}
