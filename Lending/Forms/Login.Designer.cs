
namespace Lending
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.paneMain = new System.Windows.Forms.Panel();
            this.btn_Login = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tBPass2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tBPass = new System.Windows.Forms.TextBox();
            this.tBUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.paneMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneMain
            // 
            this.paneMain.BackColor = System.Drawing.Color.White;
            this.paneMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneMain.Controls.Add(this.btn_Login);
            this.paneMain.Controls.Add(this.lblInfo);
            this.paneMain.Controls.Add(this.label1);
            this.paneMain.Controls.Add(this.tBPass2);
            this.paneMain.Controls.Add(this.label3);
            this.paneMain.Controls.Add(this.tBPass);
            this.paneMain.Controls.Add(this.tBUser);
            this.paneMain.Controls.Add(this.label2);
            this.paneMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneMain.Location = new System.Drawing.Point(0, 0);
            this.paneMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.paneMain.Name = "paneMain";
            this.paneMain.Size = new System.Drawing.Size(396, 273);
            this.paneMain.TabIndex = 0;
            // 
            // btn_Login
            // 
            this.btn_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Login.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.Location = new System.Drawing.Point(268, 213);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(114, 45);
            this.btn_Login.TabIndex = 37;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(8, 191);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(60, 19);
            this.lblInfo.TabIndex = 36;
            this.lblInfo.Text = "label4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(8, 138);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 27);
            this.label1.TabIndex = 34;
            this.label1.Text = "Confirm:";
            // 
            // tBPass2
            // 
            this.tBPass2.BackColor = System.Drawing.Color.White;
            this.tBPass2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBPass2.ForeColor = System.Drawing.Color.Black;
            this.tBPass2.Location = new System.Drawing.Point(154, 137);
            this.tBPass2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tBPass2.Name = "tBPass2";
            this.tBPass2.PasswordChar = '*';
            this.tBPass2.Size = new System.Drawing.Size(228, 31);
            this.tBPass2.TabIndex = 33;
            this.tBPass2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBPass2_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(8, 93);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 27);
            this.label3.TabIndex = 32;
            this.label3.Text = "Password:";
            // 
            // tBPass
            // 
            this.tBPass.BackColor = System.Drawing.Color.White;
            this.tBPass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBPass.ForeColor = System.Drawing.Color.Black;
            this.tBPass.Location = new System.Drawing.Point(154, 92);
            this.tBPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tBPass.Name = "tBPass";
            this.tBPass.PasswordChar = '*';
            this.tBPass.Size = new System.Drawing.Size(228, 31);
            this.tBPass.TabIndex = 31;
            // 
            // tBUser
            // 
            this.tBUser.BackColor = System.Drawing.Color.White;
            this.tBUser.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBUser.ForeColor = System.Drawing.Color.Black;
            this.tBUser.Location = new System.Drawing.Point(154, 48);
            this.tBUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tBUser.Name = "tBUser";
            this.tBUser.Size = new System.Drawing.Size(228, 31);
            this.tBUser.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(8, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 27);
            this.label2.TabIndex = 29;
            this.label2.Text = "Username:";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 273);
            this.Controls.Add(this.paneMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.logFrm_FormClosing);
            this.Load += new System.EventHandler(this.logFrm_Load);
            this.paneMain.ResumeLayout(false);
            this.paneMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBPass2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBPass;
        private System.Windows.Forms.TextBox tBUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btn_Login;
    }
}