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
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.pnlBottom, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.chkLanguagesList, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.45299F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.23077F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.8718F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.35897F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(549, 390);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.pnlBottom.Controls.Add(this.btnDownloadAndInstall);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBottom.Location = new System.Drawing.Point(0, 294);
            this.pnlBottom.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(549, 96);
            this.pnlBottom.TabIndex = 4;
            // 
            // btnDownloadAndInstall
            // 
            this.btnDownloadAndInstall.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDownloadAndInstall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(33)))), ((int)(((byte)(122)))));
            this.btnDownloadAndInstall.FlatAppearance.BorderSize = 0;
            this.btnDownloadAndInstall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownloadAndInstall.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.btnDownloadAndInstall.ForeColor = System.Drawing.Color.White;
            this.btnDownloadAndInstall.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDownloadAndInstall.Location = new System.Drawing.Point(26, 22);
            this.btnDownloadAndInstall.Name = "btnDownloadAndInstall";
            this.btnDownloadAndInstall.Size = new System.Drawing.Size(497, 52);
            this.btnDownloadAndInstall.TabIndex = 3;
            this.btnDownloadAndInstall.Text = "DOWNLOAD + INSTALL";
            this.btnDownloadAndInstall.UseVisualStyleBackColor = false;
            this.btnDownloadAndInstall.Click += new System.EventHandler(this.btnDownloadAndInstall_Click);
            // 
            // chkLanguagesList
            // 
            this.chkLanguagesList.CheckOnClick = true;
            this.chkLanguagesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkLanguagesList.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLanguagesList.FormattingEnabled = true;
            this.chkLanguagesList.Location = new System.Drawing.Point(26, 132);
            this.chkLanguagesList.Margin = new System.Windows.Forms.Padding(26, 13, 26, 13);
            this.chkLanguagesList.Name = "chkLanguagesList";
            this.chkLanguagesList.Size = new System.Drawing.Size(497, 149);
            this.chkLanguagesList.Sorted = true;
            this.chkLanguagesList.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(543, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "INSTALLED LANGUAGES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 44);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(13, 0, 13, 0);
            this.label2.Size = new System.Drawing.Size(543, 75);
            this.label2.TabIndex = 1;
            this.label2.Text = "THIS IS VERY IMPORTANT, choose only the languages that are currently installed in" +
    " your Windows Phone. To find out, in your phone go to:\r\n\"Settings\" > \"Region + L" +
    "anguage\" > tap \"Language\" listbox.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Step3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Step3";
            this.Size = new System.Drawing.Size(549, 390);
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
