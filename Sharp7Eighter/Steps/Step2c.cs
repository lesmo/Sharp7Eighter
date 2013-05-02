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
    public partial class Step2c : UserControl {
        public event EventHandler OnPrevStep;

        public Step2c() {
            InitializeComponent();
        }

        private void btnRetry_Click(object sender, EventArgs e) {
            if ( OnPrevStep != null )
                OnPrevStep(this, null);
        }

        private void btnDownload_Click(object sender, EventArgs e) {
            Process download = new Process();
            download.StartInfo.FileName = "http://forum.xda-developers.com/attachment.php?attachmentid=751891&d=1318801790";
            download.Start();
        }
    }
}
