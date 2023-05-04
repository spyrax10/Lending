namespace Lending.Forms
{
    partial class Customer
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
            this.PaneMain.SuspendLayout();
            this.PaneTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // PaneMain
            // 
            this.PaneMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PaneMain.Controls.Add(this.PaneTop);
            this.PaneMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PaneMain.Location = new System.Drawing.Point(0, 0);
            this.PaneMain.Name = "PaneMain";
            this.PaneMain.Size = new System.Drawing.Size(1170, 372);
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
            this.PaneTop.Size = new System.Drawing.Size(1168, 42);
            this.PaneTop.TabIndex = 1;
            // 
            // BTNClose
            // 
            this.BTNClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.BTNClose.FlatAppearance.BorderSize = 0;
            this.BTNClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNClose.Image = global::Lending.Properties.Resources.mono_close;
            this.BTNClose.Location = new System.Drawing.Point(1125, 0);
            this.BTNClose.Name = "BTNClose";
            this.BTNClose.Size = new System.Drawing.Size(41, 40);
            this.BTNClose.TabIndex = 2;
            this.BTNClose.UseVisualStyleBackColor = true;
            this.BTNClose.Click += new System.EventHandler(this.BTNClose_Click);
            // 
            // PBLogo
            // 
            this.PBLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.PBLogo.Image = global::Lending.Properties.Resources.prog_setup;
            this.PBLogo.Location = new System.Drawing.Point(0, 0);
            this.PBLogo.Name = "PBLogo";
            this.PBLogo.Size = new System.Drawing.Size(42, 40);
            this.PBLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBLogo.TabIndex = 1;
            this.PBLogo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Management:";
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1170, 372);
            this.Controls.Add(this.PaneMain);
            this.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Management";
            this.Click += new System.EventHandler(this.Customer_Click);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Customer_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Customer_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Customer_MouseUp);
            this.PaneMain.ResumeLayout(false);
            this.PaneTop.ResumeLayout(false);
            this.PaneTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PaneMain;
        private System.Windows.Forms.Panel PaneTop;
        private System.Windows.Forms.Button BTNClose;
        private System.Windows.Forms.PictureBox PBLogo;
        private System.Windows.Forms.Label label1;
    }
}