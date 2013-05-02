namespace Sharp7Eigther.Steps {
    partial class Step2f {
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
            this.lblMagicError = new System.Windows.Forms.Label();
            this.lblErrorDetail = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lblMagicError, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblErrorDetail, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.35897F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.64103F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(549, 390);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblMagicError
            // 
            this.lblMagicError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMagicError.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMagicError.Location = new System.Drawing.Point(3, 0);
            this.lblMagicError.Name = "lblMagicError";
            this.lblMagicError.Size = new System.Drawing.Size(543, 173);
            this.lblMagicError.TabIndex = 0;
            this.lblMagicError.Text = "UPDATEWP.EXE NOT FOUND";
            this.lblMagicError.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblErrorDetail
            // 
            this.lblErrorDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblErrorDetail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorDetail.Location = new System.Drawing.Point(3, 173);
            this.lblErrorDetail.Name = "lblErrorDetail";
            this.lblErrorDetail.Padding = new System.Windows.Forms.Padding(26, 3, 26, 26);
            this.lblErrorDetail.Size = new System.Drawing.Size(543, 217);
            this.lblErrorDetail.TabIndex = 1;
            this.lblErrorDetail.Text = "This tool comes with some files, and they seem to be missing. Make sure that the " +
    "\"External\" folder is in the same as this tool, and that it\'s not empty.";
            // 
            // Step2f
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Step2f";
            this.Size = new System.Drawing.Size(549, 390);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblMagicError;
        private System.Windows.Forms.Label lblErrorDetail;
    }
}
