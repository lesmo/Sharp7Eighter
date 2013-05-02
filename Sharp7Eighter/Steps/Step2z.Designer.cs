namespace Sharp7Eigther.Steps {
    partial class Step2z {
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
            System.Windows.Forms.Label lblZuneError;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Step2z));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnCloseAndRetry = new System.Windows.Forms.Button();
            this.btnRetry = new System.Windows.Forms.Button();
            this.picZuneLogo = new System.Windows.Forms.PictureBox();
            lblZuneError = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picZuneLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblZuneError
            // 
            resources.ApplyResources(lblZuneError, "lblZuneError");
            lblZuneError.Name = "lblZuneError";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.pnlBottom, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.picZuneLogo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(lblZuneError, 0, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.pnlBottom.Controls.Add(this.btnCloseAndRetry);
            this.pnlBottom.Controls.Add(this.btnRetry);
            resources.ApplyResources(this.pnlBottom, "pnlBottom");
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
            // picZuneLogo
            // 
            resources.ApplyResources(this.picZuneLogo, "picZuneLogo");
            this.picZuneLogo.Name = "picZuneLogo";
            this.picZuneLogo.TabStop = false;
            // 
            // Step2z
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Step2z";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picZuneLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox picZuneLogo;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnCloseAndRetry;
        private System.Windows.Forms.Button btnRetry;
    }
}
