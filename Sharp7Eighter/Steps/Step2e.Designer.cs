namespace Sharp7Eigther.Steps {
    partial class Step2e {
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
            System.Windows.Forms.Label lblErrorDesc;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Step2e));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnCloseAndRetry = new System.Windows.Forms.Button();
            this.btnRetry = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.txtError = new System.Windows.Forms.TextBox();
            lblErrorDesc = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblErrorDesc
            // 
            resources.ApplyResources(lblErrorDesc, "lblErrorDesc");
            lblErrorDesc.Name = "lblErrorDesc";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.pnlBottom, 0, 3);
            this.tableLayoutPanel1.Controls.Add(lblErrorDesc, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblError, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtError, 0, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // pnlBottom
            // 
            resources.ApplyResources(this.pnlBottom, "pnlBottom");
            this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.pnlBottom.Controls.Add(this.btnCloseAndRetry);
            this.pnlBottom.Controls.Add(this.btnRetry);
            this.pnlBottom.Name = "pnlBottom";
            // 
            // btnCloseAndRetry
            // 
            resources.ApplyResources(this.btnCloseAndRetry, "btnCloseAndRetry");
            this.btnCloseAndRetry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(33)))), ((int)(((byte)(122)))));
            this.btnCloseAndRetry.FlatAppearance.BorderSize = 0;
            this.btnCloseAndRetry.ForeColor = System.Drawing.Color.White;
            this.btnCloseAndRetry.Name = "btnCloseAndRetry";
            this.btnCloseAndRetry.UseVisualStyleBackColor = false;
            this.btnCloseAndRetry.Click += new System.EventHandler(this.btnCloseAndRetry_Click);
            // 
            // btnRetry
            // 
            resources.ApplyResources(this.btnRetry, "btnRetry");
            this.btnRetry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(33)))), ((int)(((byte)(122)))));
            this.btnRetry.FlatAppearance.BorderSize = 0;
            this.btnRetry.ForeColor = System.Drawing.Color.White;
            this.btnRetry.Name = "btnRetry";
            this.btnRetry.UseVisualStyleBackColor = false;
            this.btnRetry.Click += new System.EventHandler(this.btnRetry_Click);
            // 
            // lblError
            // 
            resources.ApplyResources(this.lblError, "lblError");
            this.lblError.Name = "lblError";
            // 
            // txtError
            // 
            resources.ApplyResources(this.txtError, "txtError");
            this.txtError.Name = "txtError";
            this.txtError.ReadOnly = true;
            // 
            // Step2e
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Step2e";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnCloseAndRetry;
        private System.Windows.Forms.Button btnRetry;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.TextBox txtError;
    }
}
