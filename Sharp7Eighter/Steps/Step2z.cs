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
    public partial class Step2z : UserControl {
        public event EventHandler OnPrevStep;
        
        public Step2z() {
            InitializeComponent();
        }

        private void btnRetry_Click(object sender, EventArgs e) {
            if ( OnPrevStep != null )
                OnPrevStep(this, null);
        }

        private void btnCloseAndRetry_Click(object sender, EventArgs e) {
            foreach ( Process process in Process.GetProcessesByName("zune") )
                process.Kill();

            this.btnRetry_Click(sender, e);
        }
    }
}
