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
    public partial class Step4r : UserControl {
        public event EventHandler OnPrevStep;

        public Step4r() {
            InitializeComponent();
        }

        private void btnRetry_Click(object sender, EventArgs e) {
            if ( OnPrevStep != null )
                this.OnPrevStep(this, null);
        }
    }
}
