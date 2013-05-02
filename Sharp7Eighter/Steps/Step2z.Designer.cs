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
            lblZuneError.Dock = System.Windows.Forms.DockStyle.Fill;
            lblZuneError.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblZuneError.Location = new System.Drawing.Point(3, 115);
            lblZuneError.Name = "lblZuneError";
            lblZuneError.Padding = new System.Windows.Forms.Padding(13, 0, 13, 13);
            lblZuneError.Size = new System.Drawing.Size(543, 179);
            lblZuneError.TabIndex = 1;
            lblZuneError.Text = "Zune Software is open, you must close it before we continue. The update does not " +
    "need it.\r\n\r\nClick \"Close and Retry\" so we can try to close Zune for you and rest" +
    "art the environment validation.";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.pnlBottom, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.picZuneLogo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(lblZuneError, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.11565F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.88435F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(549, 390);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.pnlBottom.Controls.Add(this.btnCloseAndRetry);
            this.pnlBottom.Controls.Add(this.btnRetry);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBottom.Location = new System.Drawing.Point(0, 294);
            this.pnlBottom.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(549, 96);
            this.pnlBottom.TabIndex = 3;
            // 
            // btnCloseAndRetry
            // 
            this.btnCloseAndRetry.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseAndRetry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(33)))), ((int)(((byte)(122)))));
            this.btnCloseAndRetry.FlatAppearance.BorderSize = 0;
            this.btnCloseAndRetry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseAndRetry.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.btnCloseAndRetry.ForeColor = System.Drawing.Color.White;
            this.btnCloseAndRetry.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCloseAndRetry.Location = new System.Drawing.Point(230, 22);
            this.btnCloseAndRetry.Name = "btnCloseAndRetry";
            this.btnCloseAndRetry.Size = new System.Drawing.Size(296, 52);
            this.btnCloseAndRetry.TabIndex = 3;
            this.btnCloseAndRetry.Text = "CLOSE && RETRY";
            this.btnCloseAndRetry.UseVisualStyleBackColor = false;
            this.btnCloseAndRetry.Click += new System.EventHandler(this.btnCloseAndRetry_Click);
            // 
            // btnRetry
            // 
            this.btnRetry.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRetry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(33)))), ((int)(((byte)(122)))));
            this.btnRetry.FlatAppearance.BorderSize = 0;
            this.btnRetry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetry.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.btnRetry.ForeColor = System.Drawing.Color.White;
            this.btnRetry.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRetry.Location = new System.Drawing.Point(27, 22);
            this.btnRetry.Name = "btnRetry";
            this.btnRetry.Size = new System.Drawing.Size(147, 52);
            this.btnRetry.TabIndex = 2;
            this.btnRetry.Text = "RETRY";
            this.btnRetry.UseVisualStyleBackColor = false;
            this.btnRetry.Click += new System.EventHandler(this.btnRetry_Click);
            // 
            // picZuneLogo
            // 
            this.picZuneLogo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.picZuneLogo.Image = ((System.Drawing.Image)(resources.GetObject("picZuneLogo.Image")));
            this.picZuneLogo.Location = new System.Drawing.Point(28, 52);
            this.picZuneLogo.Margin = new System.Windows.Forms.Padding(28, 28, 28, 13);
            this.picZuneLogo.Name = "picZuneLogo";
            this.picZuneLogo.Size = new System.Drawing.Size(493, 50);
            this.picZuneLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picZuneLogo.TabIndex = 0;
            this.picZuneLogo.TabStop = false;
            // 
            // Step2z
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Step2z";
            this.Size = new System.Drawing.Size(549, 390);
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
