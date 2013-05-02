using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;

namespace Sharp7Eigther {
    public partial class Main : Form {
        public const int AnimationSpeed = 30;
        
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Main() {
            InitializeComponent();

            // Initialize the other steps and events
            Steps.Step2 Step2 = new Steps.Step2(this);
            Step1.OnNextStep += (object sender, EventArgs e) => {
                MoveToStep_RightAnimation(Step1, Step2);
                Step2.MainCallback();
                Step1.Dispose();
            };

            Steps.Step3 Step3 = new Steps.Step3(this);
            Step2.OnNextStep += (object sender, EventArgs e) => {
                MoveToStep_RightAnimation(Step2, Step3);
                Step2.Dispose();

                this.lblTitleBar.Text = DeviceInfo.Name + " (" + DeviceInfo.Model + ") v" + DeviceInfo.Revision;
                Step3.MainCallback();
            };

            Steps.Step4 Step4 = new Steps.Step4(this, Step3.langSelectedIndexes);
            Step3.OnNextStep += (object sender, EventArgs e) => {
                MoveToStep_RightAnimation((UserControl)sender, Step4);
                Step4.MainCallback();
            };

            Step4.OnNextStep += (object sender, EventArgs e) => {
                MoveToStep_RightAnimation(Step4, new Steps.Step5());
            };
        }

        public void MoveToStep_RightAnimation(UserControl currentStep = null, UserControl nextStep = null) {
            if ( currentStep != null ) {
                while ( currentStep.Location.X - AnimationSpeed + currentStep.Width > 0 ) {
                    currentStep.Location = new Point(currentStep.Location.X - AnimationSpeed, 0);
                    Application.DoEvents();
                }
                currentStep.Visible = false;
            }

            if ( nextStep != null ) {
                nextStep.Visible = false;
                nextStep.Parent = panelMain;
                nextStep.Width = panelMain.Width;
                nextStep.Height = panelMain.Height;
                nextStep.Location = new Point(this.Width + 3, 0);
                nextStep.Visible = true;

                while ( nextStep.Location.X - AnimationSpeed > 0 ) {
                    nextStep.Location = new Point(nextStep.Location.X - AnimationSpeed, 0);
                    Application.DoEvents();
                }

                nextStep.Location = new Point(0, 0);
            }
        }

        public void MoveToStep_LeftAnimation(UserControl currentStep = null, UserControl prevStep = null) {
            if ( currentStep != null ) {
                while ( currentStep.Location.X + AnimationSpeed < this.Width + 3 ) {
                    currentStep.Location = new Point(currentStep.Location.X + AnimationSpeed, 0);
                    Application.DoEvents();
                }
                currentStep.Visible = false;
            }

            if ( prevStep != null ) {
                prevStep.Visible = false;
                prevStep.Parent = panelMain;
                prevStep.Width = panelMain.Width;
                prevStep.Height = panelMain.Height;
                prevStep.Location = new Point(0 - prevStep.Width - 3, 0);
                prevStep.Visible = true;

                while ( prevStep.Location.X < 0 ) {
                    prevStep.Location = new Point(prevStep.Location.X + AnimationSpeed, 0);
                    Application.DoEvents();
                }

                prevStep.Location = new Point(0,0);
            }
        }

        private void MoveWindow_MouseDown(object sender, MouseEventArgs e) {
            ReleaseCapture();
            SendMessage(Handle, 0xA1, 0x2, 0);
        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}