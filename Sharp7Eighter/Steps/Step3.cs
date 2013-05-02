using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Globalization;
using System.Collections;

namespace Sharp7Eigther.Steps {
    public partial class Step3 : UserControl {
        public event EventHandler OnNextStep;

        private Dictionary<string, int> langNamesIndex = new Dictionary<string, int>();
        public ArrayList langSelectedIndexes = new ArrayList();

        private Main MainForm;

        public Step3(Main MainForm) {
            InitializeComponent();
            this.MainForm = MainForm;
        }

        public void MainCallback() {
            int i = 0;
            foreach ( string languageCodeStr in Properties.Settings.Default.AvailableLanguages ) {
                CultureInfo culture = new CultureInfo(Convert.ToInt32(languageCodeStr, 16));
                string langName = culture.NativeName[0].ToString().ToUpper();
                langName += culture.NativeName.Substring(1);

                this.langNamesIndex.Add(langName, i++);

                if ( Properties.Settings.Default.SelectedLanguages.IndexOf(langName) > -1 )
                    this.chkLanguagesList.Items.Add(langName, true);
                else 
                    this.chkLanguagesList.Items.Add(langName);
            }
        }

        private void btnDownloadAndInstall_Click(object sender_downloadAndInstall, EventArgs e_downloadAndInstall) {
            Step3v Step3v = new Step3v();

            Step3v.lblLanguages.Text = "";
            foreach ( string item in this.chkLanguagesList.CheckedItems )
                Step3v.lblLanguages.Text += item + "\n";

            Properties.Settings.Default.SelectedLanguages.Clear();

            foreach ( string item in this.chkLanguagesList.CheckedItems ) {
                Properties.Settings.Default.SelectedLanguages.Add(item);
                langSelectedIndexes.Add(langNamesIndex[item]);
            }

            Properties.Settings.Default.Save();

            Step3v.OnPrevStep += (object sender, EventArgs e) => {
                this.MainForm.MoveToStep_LeftAnimation(Step3v, this);
                Step3v.Dispose();
            };
            Step3v.OnNextStep += this.OnNextStep;
            
            this.MainForm.MoveToStep_RightAnimation(this, Step3v);
        }
    }
}