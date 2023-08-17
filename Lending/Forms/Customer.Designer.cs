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
            this.btnToggle = new System.Windows.Forms.Button();
            this.PaneTop = new System.Windows.Forms.Panel();
            this.BTNClose = new System.Windows.Forms.Button();
            this.PBLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PaneAdd = new System.Windows.Forms.FlowLayoutPanel();
            this.tBFirstName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.PaneMain.SuspendLayout();
            this.PaneTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).BeginInit();
            this.PaneAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // PaneMain
            // 
            this.PaneMain.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PaneMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PaneMain.Controls.Add(this.PaneAdd);
            this.PaneMain.Controls.Add(this.btnToggle);
            this.PaneMain.Controls.Add(this.PaneTop);
            this.PaneMain.Location = new System.Drawing.Point(0, 0);
            this.PaneMain.Name = "PaneMain";
            this.PaneMain.Size = new System.Drawing.Size(1114, 752);
            this.PaneMain.TabIndex = 0;
            // 
            // btnToggle
            // 
            this.btnToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToggle.Location = new System.Drawing.Point(269, 330);
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnToggle.Size = new System.Drawing.Size(40, 98);
            this.btnToggle.TabIndex = 3;
            this.btnToggle.Text = "NEW";
            this.btnToggle.UseVisualStyleBackColor = true;
            this.btnToggle.Click += new System.EventHandler(this.btnToggle_Click);
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
            this.PaneTop.Size = new System.Drawing.Size(1112, 42);
            this.PaneTop.TabIndex = 1;
            // 
            // BTNClose
            // 
            this.BTNClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.BTNClose.FlatAppearance.BorderSize = 0;
            this.BTNClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNClose.Image = global::Lending.Properties.Resources.mono_close;
            this.BTNClose.Location = new System.Drawing.Point(1069, 0);
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
            // PaneAdd
            // 
            this.PaneAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PaneAdd.Controls.Add(this.label12);
            this.PaneAdd.Controls.Add(this.tBFirstName);
            this.PaneAdd.Controls.Add(this.label2);
            this.PaneAdd.Controls.Add(this.textBox1);
            this.PaneAdd.Controls.Add(this.label3);
            this.PaneAdd.Controls.Add(this.textBox2);
            this.PaneAdd.Controls.Add(this.label4);
            this.PaneAdd.Controls.Add(this.textBox3);
            this.PaneAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.PaneAdd.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.PaneAdd.Location = new System.Drawing.Point(0, 42);
            this.PaneAdd.Name = "PaneAdd";
            this.PaneAdd.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.PaneAdd.Size = new System.Drawing.Size(268, 708);
            this.PaneAdd.TabIndex = 4;
            // 
            // tBFirstName
            // 
            this.tBFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBFirstName.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBFirstName.ForeColor = System.Drawing.Color.Black;
            this.tBFirstName.Location = new System.Drawing.Point(15, 51);
            this.tBFirstName.MaxLength = 200;
            this.tBFirstName.Name = "tBFirstName";
            this.tBFirstName.Size = new System.Drawing.Size(248, 34);
            this.tBFirstName.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(148, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 28);
            this.label12.TabIndex = 10;
            this.label12.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(150, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 28);
            this.label2.TabIndex = 12;
            this.label2.Text = "Last Name:";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(15, 119);
            this.textBox1.MaxLength = 200;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(248, 34);
            this.textBox1.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(198, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 28);
            this.label3.TabIndex = 14;
            this.label3.Text = "Email:";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(15, 187);
            this.textBox2.MaxLength = 200;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(248, 34);
            this.textBox2.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(183, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 28);
            this.label4.TabIndex = 16;
            this.label4.Text = "Mobile:";
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.Black;
            this.textBox3.Location = new System.Drawing.Point(15, 255);
            this.textBox3.MaxLength = 200;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(248, 34);
            this.textBox3.TabIndex = 17;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1114, 752);
            this.Controls.Add(this.PaneMain);
            this.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Customer Management";
            this.Load += new System.EventHandler(this.Customer_Load);
            this.Click += new System.EventHandler(this.Customer_Click);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Customer_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Customer_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Customer_MouseUp);
            this.PaneMain.ResumeLayout(false);
            this.PaneTop.ResumeLayout(false);
            this.PaneTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).EndInit();
            this.PaneAdd.ResumeLayout(false);
            this.PaneAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PaneMain;
        private System.Windows.Forms.Panel PaneTop;
        private System.Windows.Forms.Button BTNClose;
        private System.Windows.Forms.PictureBox PBLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnToggle;
        private System.Windows.Forms.FlowLayoutPanel PaneAdd;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tBFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
    }
}