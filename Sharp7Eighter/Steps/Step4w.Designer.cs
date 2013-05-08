namespace Sharp7Eigther.Steps {
    partial class Step4w {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if ( disposing && (components != null) ) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Step4w));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblMagicError = new System.Windows.Forms.Label();
            this.lblErrorDetail = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.lblMagicError, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblErrorDetail, 0, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // lblMagicError
            // 
            resources.ApplyResources(this.lblMagicError, "lblMagicError");
            this.lblMagicError.Name = "lblMagicError";
            // 
            // lblErrorDetail
            // 
            resources.ApplyResources(this.lblErrorDetail, "lblErrorDetail");
            this.lblErrorDetail.Name = "lblErrorDetail";
            // 
            // Step4w
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Step4w";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblMagicError;
        public System.Windows.Forms.Label lblErrorDetail;
    }
}
