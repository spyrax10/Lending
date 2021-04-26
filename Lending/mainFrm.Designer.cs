
namespace Lending
{
    partial class mainFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainFrm));
            this.paneMain = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.paneLeft = new System.Windows.Forms.Panel();
            this.btnOut = new System.Windows.Forms.Button();
            this.paneLogo = new System.Windows.Forms.Panel();
            this.pBLogo = new System.Windows.Forms.PictureBox();
            this.paneMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.paneLeft.SuspendLayout();
            this.paneLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // paneMain
            // 
            this.paneMain.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.paneMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneMain.Controls.Add(this.panel1);
            this.paneMain.Controls.Add(this.paneLeft);
            this.paneMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneMain.Location = new System.Drawing.Point(0, 0);
            this.paneMain.Margin = new System.Windows.Forms.Padding(4);
            this.paneMain.Name = "paneMain";
            this.paneMain.Size = new System.Drawing.Size(1069, 588);
            this.paneMain.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(241, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 413);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(419, 28);
            this.panel2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Lending.Properties.Resources.Button_Close_icon__16_;
            this.button1.Location = new System.Drawing.Point(392, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(207, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Customer Information:";
            // 
            // paneLeft
            // 
            this.paneLeft.BackColor = System.Drawing.Color.White;
            this.paneLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneLeft.Controls.Add(this.btnOut);
            this.paneLeft.Controls.Add(this.paneLogo);
            this.paneLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.paneLeft.Location = new System.Drawing.Point(0, 0);
            this.paneLeft.Margin = new System.Windows.Forms.Padding(4);
            this.paneLeft.Name = "paneLeft";
            this.paneLeft.Size = new System.Drawing.Size(179, 586);
            this.paneLeft.TabIndex = 0;
            // 
            // btnOut
            // 
            this.btnOut.FlatAppearance.BorderSize = 0;
            this.btnOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOut.Image = global::Lending.Properties.Resources.door_in_icon;
            this.btnOut.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOut.Location = new System.Drawing.Point(3, 546);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(38, 35);
            this.btnOut.TabIndex = 1;
            this.btnOut.UseVisualStyleBackColor = true;
            // 
            // paneLogo
            // 
            this.paneLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneLogo.Controls.Add(this.pBLogo);
            this.paneLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneLogo.Location = new System.Drawing.Point(0, 0);
            this.paneLogo.Margin = new System.Windows.Forms.Padding(4);
            this.paneLogo.Name = "paneLogo";
            this.paneLogo.Size = new System.Drawing.Size(177, 91);
            this.paneLogo.TabIndex = 0;
            // 
            // pBLogo
            // 
            this.pBLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBLogo.Image = global::Lending.Properties.Resources.Joker_Wallpaper_1;
            this.pBLogo.Location = new System.Drawing.Point(20, 19);
            this.pBLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pBLogo.Name = "pBLogo";
            this.pBLogo.Size = new System.Drawing.Size(136, 52);
            this.pBLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBLogo.TabIndex = 0;
            this.pBLogo.TabStop = false;
            // 
            // mainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 588);
            this.Controls.Add(this.paneMain);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "mainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainFrm_FormClosing);
            this.Load += new System.EventHandler(this.mainFrm_Load);
            this.paneMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.paneLeft.ResumeLayout(false);
            this.paneLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneMain;
        private System.Windows.Forms.Panel paneLeft;
        private System.Windows.Forms.Panel paneLogo;
        private System.Windows.Forms.PictureBox pBLogo;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}