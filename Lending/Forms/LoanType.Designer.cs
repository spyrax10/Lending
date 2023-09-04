namespace Lending.Forms
{
    partial class LoanType
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PaneMain = new System.Windows.Forms.Panel();
            this.PaneTop = new System.Windows.Forms.Panel();
            this.BTNClose = new System.Windows.Forms.Button();
            this.PBLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FLAddLoanType = new System.Windows.Forms.FlowLayoutPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.tBTypeName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NUPLoanDays = new System.Windows.Forms.NumericUpDown();
            this.PaneMain.SuspendLayout();
            this.PaneTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).BeginInit();
            this.FLAddLoanType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUPLoanDays)).BeginInit();
            this.SuspendLayout();
            // 
            // PaneMain
            // 
            this.PaneMain.BackColor = System.Drawing.Color.White;
            this.PaneMain.Controls.Add(this.FLAddLoanType);
            this.PaneMain.Controls.Add(this.PaneTop);
            this.PaneMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PaneMain.Location = new System.Drawing.Point(0, 0);
            this.PaneMain.Name = "PaneMain";
            this.PaneMain.Size = new System.Drawing.Size(916, 565);
            this.PaneMain.TabIndex = 0;
            // 
            // PaneTop
            // 
            this.PaneTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PaneTop.Controls.Add(this.BTNClose);
            this.PaneTop.Controls.Add(this.PBLogo);
            this.PaneTop.Controls.Add(this.label1);
            this.PaneTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PaneTop.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaneTop.Location = new System.Drawing.Point(0, 0);
            this.PaneTop.Name = "PaneTop";
            this.PaneTop.Size = new System.Drawing.Size(916, 42);
            this.PaneTop.TabIndex = 2;
            // 
            // BTNClose
            // 
            this.BTNClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.BTNClose.FlatAppearance.BorderSize = 0;
            this.BTNClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNClose.Image = global::Lending.Properties.Resources.mono_close;
            this.BTNClose.Location = new System.Drawing.Point(873, 0);
            this.BTNClose.Name = "BTNClose";
            this.BTNClose.Size = new System.Drawing.Size(41, 40);
            this.BTNClose.TabIndex = 2;
            this.BTNClose.UseVisualStyleBackColor = true;
            this.BTNClose.Click += new System.EventHandler(this.BTNClose_Click);
            // 
            // PBLogo
            // 
            this.PBLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.PBLogo.Image = global::Lending.Properties.Resources.Loan_Type_32_;
            this.PBLogo.Location = new System.Drawing.Point(0, 0);
            this.PBLogo.Name = "PBLogo";
            this.PBLogo.Size = new System.Drawing.Size(32, 40);
            this.PBLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PBLogo.TabIndex = 1;
            this.PBLogo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loan Type Setup:";
            // 
            // FLAddLoanType
            // 
            this.FLAddLoanType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FLAddLoanType.Controls.Add(this.label12);
            this.FLAddLoanType.Controls.Add(this.tBTypeName);
            this.FLAddLoanType.Controls.Add(this.label2);
            this.FLAddLoanType.Controls.Add(this.NUPLoanDays);
            this.FLAddLoanType.Dock = System.Windows.Forms.DockStyle.Left;
            this.FLAddLoanType.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.FLAddLoanType.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FLAddLoanType.Location = new System.Drawing.Point(0, 42);
            this.FLAddLoanType.Name = "FLAddLoanType";
            this.FLAddLoanType.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.FLAddLoanType.Size = new System.Drawing.Size(227, 523);
            this.FLAddLoanType.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Gray;
            this.label12.Location = new System.Drawing.Point(102, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 28);
            this.label12.TabIndex = 12;
            this.label12.Text = "Type Name:";
            // 
            // tBTypeName
            // 
            this.tBTypeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBTypeName.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBTypeName.ForeColor = System.Drawing.Color.Black;
            this.tBTypeName.Location = new System.Drawing.Point(6, 51);
            this.tBTypeName.MaxLength = 200;
            this.tBTypeName.Name = "tBTypeName";
            this.tBTypeName.Size = new System.Drawing.Size(216, 34);
            this.tBTypeName.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(56, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 28);
            this.label2.TabIndex = 14;
            this.label2.Text = "Number of Days:";
            // 
            // NUPLoanDays
            // 
            this.NUPLoanDays.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUPLoanDays.Location = new System.Drawing.Point(6, 119);
            this.NUPLoanDays.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.NUPLoanDays.Name = "NUPLoanDays";
            this.NUPLoanDays.Size = new System.Drawing.Size(216, 34);
            this.NUPLoanDays.TabIndex = 16;
            // 
            // LoanType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 565);
            this.Controls.Add(this.PaneMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoanType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "LoanType";
            this.TopMost = true;
            this.PaneMain.ResumeLayout(false);
            this.PaneTop.ResumeLayout(false);
            this.PaneTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).EndInit();
            this.FLAddLoanType.ResumeLayout(false);
            this.FLAddLoanType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUPLoanDays)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PaneMain;
        private System.Windows.Forms.Panel PaneTop;
        private System.Windows.Forms.Button BTNClose;
        private System.Windows.Forms.PictureBox PBLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel FLAddLoanType;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tBTypeName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NUPLoanDays;
    }
}