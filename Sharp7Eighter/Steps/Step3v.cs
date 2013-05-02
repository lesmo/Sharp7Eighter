using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sharp7Eigther.Steps {
    public partial class Step3v : UserControl {
        public event EventHandler OnPrevStep;
        public event EventHandler OnNextStep;

        public Step3v() {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e) {
            if ( OnPrevStep != null )
                OnPrevStep(this, null);
        }

        private void btnContinue_Click(object sender, EventArgs e) {
            if ( OnNextStep != null )
                OnNextStep(this, null);
        }
    }
}
