namespace Sharp7Eigther.Steps {
    partial class Step3 {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Step3));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnDownloadAndInstall = new System.Windows.Forms.Button();
            this.chkLanguagesList = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.pnlBottom, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.chkLanguagesList, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // pnlBottom
            // 
            resources.ApplyResources(this.pnlBottom, "pnlBottom");
            this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.pnlBottom.Controls.Add(this.btnDownloadAndInstall);
            this.pnlBottom.Name = "pnlBottom";
            // 
            // btnDownloadAndInstall
            // 
            resources.ApplyResources(this.btnDownloadAndInstall, "btnDownloadAndInstall");
            this.btnDownloadAndInstall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(33)))), ((int)(((byte)(122)))));
            this.btnDownloadAndInstall.FlatAppearance.BorderSize = 0;
            this.btnDownloadAndInstall.ForeColor = System.Drawing.Color.White;
            this.btnDownloadAndInstall.Name = "btnDownloadAndInstall";
            this.btnDownloadAndInstall.UseVisualStyleBackColor = false;
            this.btnDownloadAndInstall.Click += new System.EventHandler(this.btnDownloadAndInstall_Click);
            // 
            // chkLanguagesList
            // 
            resources.ApplyResources(this.chkLanguagesList, "chkLanguagesList");
            this.chkLanguagesList.CheckOnClick = true;
            this.chkLanguagesList.FormattingEnabled = true;
            this.chkLanguagesList.Name = "chkLanguagesList";
            this.chkLanguagesList.Sorted = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // Step3
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Step3";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox chkLanguagesList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnDownloadAndInstall;
    }
}
