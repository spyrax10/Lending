
namespace Lending
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.Main = new System.Windows.Forms.Panel();
            this.cBServer = new System.Windows.Forms.ComboBox();
            this.chkSQL = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tBPass = new System.Windows.Forms.TextBox();
            this.tBUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFoldPath = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tBPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main
            // 
            this.Main.BackColor = System.Drawing.Color.White;
            this.Main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Main.Controls.Add(this.cBServer);
            this.Main.Controls.Add(this.chkSQL);
            this.Main.Controls.Add(this.label3);
            this.Main.Controls.Add(this.tBPass);
            this.Main.Controls.Add(this.tBUser);
            this.Main.Controls.Add(this.label2);
            this.Main.Controls.Add(this.label1);
            this.Main.Controls.Add(this.btnFoldPath);
            this.Main.Controls.Add(this.panel1);
            this.Main.Controls.Add(this.tBPath);
            this.Main.Controls.Add(this.label4);
            this.Main.Controls.Add(this.btnSave);
            this.Main.Controls.Add(this.btnTest);
            this.Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main.Location = new System.Drawing.Point(0, 0);
            this.Main.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(460, 437);
            this.Main.TabIndex = 0;
            // 
            // cBServer
            // 
            this.cBServer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBServer.FormattingEnabled = true;
            this.cBServer.Location = new System.Drawing.Point(141, 170);
            this.cBServer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cBServer.Name = "cBServer";
            this.cBServer.Size = new System.Drawing.Size(277, 31);
            this.cBServer.TabIndex = 25;
            // 
            // chkSQL
            // 
            this.chkSQL.AutoSize = true;
            this.chkSQL.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkSQL.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSQL.ForeColor = System.Drawing.Color.Black;
            this.chkSQL.Location = new System.Drawing.Point(154, 306);
            this.chkSQL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkSQL.Name = "chkSQL";
            this.chkSQL.Size = new System.Drawing.Size(268, 25);
            this.chkSQL.TabIndex = 24;
            this.chkSQL.Text = "Use Window Authentication";
            this.chkSQL.UseVisualStyleBackColor = true;
            this.chkSQL.CheckedChanged += new System.EventHandler(this.chkSQL_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(12, 263);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 27);
            this.label3.TabIndex = 22;
            this.label3.Text = "Password:";
            // 
            // tBPass
            // 
            this.tBPass.BackColor = System.Drawing.Color.White;
            this.tBPass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBPass.ForeColor = System.Drawing.Color.Black;
            this.tBPass.Location = new System.Drawing.Point(141, 261);
            this.tBPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tBPass.Name = "tBPass";
            this.tBPass.PasswordChar = '*';
            this.tBPass.Size = new System.Drawing.Size(277, 31);
            this.tBPass.TabIndex = 21;
            // 
            // tBUser
            // 
            this.tBUser.BackColor = System.Drawing.Color.White;
            this.tBUser.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBUser.ForeColor = System.Drawing.Color.Black;
            this.tBUser.Location = new System.Drawing.Point(141, 216);
            this.tBUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tBUser.Name = "tBUser";
            this.tBUser.Size = new System.Drawing.Size(277, 31);
            this.tBUser.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(12, 218);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 27);
            this.label2.TabIndex = 19;
            this.label2.Text = "Username:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(10, 173);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 27);
            this.label1.TabIndex = 17;
            this.label1.Text = "Server:";
            // 
            // btnFoldPath
            // 
            this.btnFoldPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFoldPath.FlatAppearance.BorderSize = 0;
            this.btnFoldPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFoldPath.Image = global::Lending.Properties.Resources.folder_search_icon;
            this.btnFoldPath.Location = new System.Drawing.Point(396, 61);
            this.btnFoldPath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFoldPath.Name = "btnFoldPath";
            this.btnFoldPath.Size = new System.Drawing.Size(38, 38);
            this.btnFoldPath.TabIndex = 14;
            this.btnFoldPath.UseVisualStyleBackColor = true;
            this.btnFoldPath.Click += new System.EventHandler(this.btnFoldPath_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(16, 129);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 4);
            this.panel1.TabIndex = 13;
            // 
            // tBPath
            // 
            this.tBPath.BackColor = System.Drawing.Color.White;
            this.tBPath.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBPath.ForeColor = System.Drawing.Color.Black;
            this.tBPath.Location = new System.Drawing.Point(16, 64);
            this.tBPath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tBPath.Name = "tBPath";
            this.tBPath.Size = new System.Drawing.Size(364, 31);
            this.tBPath.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(10, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(260, 27);
            this.label4.TabIndex = 11;
            this.label4.Text = "Lending Report Folder:";
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(242, 369);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(200, 45);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "SAVE SETTINGS";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnTest
            // 
            this.btnTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTest.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTest.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest.Location = new System.Drawing.Point(16, 369);
            this.btnTest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(200, 45);
            this.btnTest.TabIndex = 9;
            this.btnTest.Text = "TEST CONNECTION";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(460, 437);
            this.Controls.Add(this.Main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Application Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.setFrm_FormClosing);
            this.Load += new System.EventHandler(this.setFrm_Load);
            this.Main.ResumeLayout(false);
            this.Main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Main;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tBPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFoldPath;
        private System.Windows.Forms.CheckBox chkSQL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBPass;
        private System.Windows.Forms.TextBox tBUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBServer;
    }
}

