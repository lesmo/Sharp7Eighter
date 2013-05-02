using System;
using System.Windows.Forms;

namespace Sharp7Eigther.Steps {
    public partial class Step1 : UserControl {
        public event EventHandler OnNextStep;

        public Step1() {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e) {
            if ( OnNextStep != null )
                OnNextStep(this, null);
        }
    }
}
