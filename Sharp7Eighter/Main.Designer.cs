namespace Sharp7Eigther {
    partial class Main {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.tblTitleBar = new System.Windows.Forms.TableLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.picWpLogo = new System.Windows.Forms.PictureBox();
            this.lblTitleBar = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.Step1 = new Sharp7Eigther.Steps.Step1();
            this.tblMain.SuspendLayout();
            this.tblTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWpLogo)).BeginInit();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblMain.ColumnCount = 1;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Controls.Add(this.tblTitleBar, 0, 0);
            this.tblMain.Controls.Add(this.panelMain, 0, 1);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.ForeColor = System.Drawing.Color.Black;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Margin = new System.Windows.Forms.Padding(0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 2;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.84018F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.15982F));
            this.tblMain.Size = new System.Drawing.Size(564, 438);
            this.tblMain.TabIndex = 2;
            // 
            // tblTitleBar
            // 
            this.tblTitleBar.ColumnCount = 3;
            this.tblTitleBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.602151F));
            this.tblTitleBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.18279F));
            this.tblTitleBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblTitleBar.Controls.Add(this.btnClose, 2, 0);
            this.tblTitleBar.Controls.Add(this.picWpLogo, 0, 0);
            this.tblTitleBar.Controls.Add(this.lblTitleBar, 1, 0);
            this.tblTitleBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblTitleBar.Location = new System.Drawing.Point(4, 4);
            this.tblTitleBar.Name = "tblTitleBar";
            this.tblTitleBar.RowCount = 1;
            this.tblTitleBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblTitleBar.Size = new System.Drawing.Size(556, 58);
            this.tblTitleBar.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(33)))), ((int)(((byte)(122)))));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnClose.Location = new System.Drawing.Point(506, 7);
            this.btnClose.Margin = new System.Windows.Forms.Padding(7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(43, 44);
            this.btnClose.TabIndex = 10;
            this.btnClose.TabStop = false;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // picWpLogo
            // 
            this.picWpLogo.Dock = System.Windows.Forms.DockStyle.Right;
            this.picWpLogo.Image = ((System.Drawing.Image)(resources.GetObject("picWpLogo.Image")));
            this.picWpLogo.Location = new System.Drawing.Point(9, 0);
            this.picWpLogo.Margin = new System.Windows.Forms.Padding(0);
            this.picWpLogo.Name = "picWpLogo";
            this.picWpLogo.Size = new System.Drawing.Size(38, 58);
            this.picWpLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picWpLogo.TabIndex = 2;
            this.picWpLogo.TabStop = false;
            this.picWpLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow_MouseDown);
            // 
            // lblTitleBar
            // 
            this.lblTitleBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitleBar.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(33)))), ((int)(((byte)(122)))));
            this.lblTitleBar.Location = new System.Drawing.Point(47, 0);
            this.lblTitleBar.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblTitleBar.Name = "lblTitleBar";
            this.lblTitleBar.Size = new System.Drawing.Size(452, 53);
            this.lblTitleBar.TabIndex = 3;
            this.lblTitleBar.Text = "Windows Phone";
            this.lblTitleBar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow_MouseDown);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.Step1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(1, 66);
            this.panelMain.Margin = new System.Windows.Forms.Padding(0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(562, 371);
            this.panelMain.TabIndex = 3;
            // 
            // Step1
            // 
            this.Step1.BackColor = System.Drawing.Color.Transparent;
            this.Step1.Location = new System.Drawing.Point(0, 0);
            this.Step1.Margin = new System.Windows.Forms.Padding(0);
            this.Step1.Name = "Step1";
            this.Step1.Size = new System.Drawing.Size(564, 374);
            this.Step1.TabIndex = 4;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(564, 438);
            this.ControlBox = false;
            this.Controls.Add(this.tblMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sharp 7Eigther";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow_MouseDown);
            this.tblMain.ResumeLayout(false);
            this.tblTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picWpLogo)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblMain;
        private System.Windows.Forms.TableLayoutPanel tblTitleBar;
        private System.Windows.Forms.PictureBox picWpLogo;
        private System.Windows.Forms.Label lblTitleBar;
        public System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panelMain;
        private Steps.Step1 Step1;

    }
}

