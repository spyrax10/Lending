
namespace Lending
{
    partial class logFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(logFrm));
            this.paneMain = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tBPass = new System.Windows.Forms.TextBox();
            this.tBUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.paneMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneMain
            // 
            this.paneMain.BackColor = System.Drawing.Color.White;
            this.paneMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneMain.Controls.Add(this.lblInfo);
            this.paneMain.Controls.Add(this.label1);
            this.paneMain.Controls.Add(this.textBox1);
            this.paneMain.Controls.Add(this.label3);
            this.paneMain.Controls.Add(this.tBPass);
            this.paneMain.Controls.Add(this.tBUser);
            this.paneMain.Controls.Add(this.label2);
            this.paneMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneMain.Location = new System.Drawing.Point(0, 0);
            this.paneMain.Name = "paneMain";
            this.paneMain.Size = new System.Drawing.Size(257, 136);
            this.paneMain.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(5, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 34;
            this.label1.Text = "Confirm:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(91, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(153, 23);
            this.textBox1.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(5, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 18);
            this.label3.TabIndex = 32;
            this.label3.Text = "Password:";
            // 
            // tBPass
            // 
            this.tBPass.BackColor = System.Drawing.Color.White;
            this.tBPass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBPass.ForeColor = System.Drawing.Color.Black;
            this.tBPass.Location = new System.Drawing.Point(91, 56);
            this.tBPass.Name = "tBPass";
            this.tBPass.PasswordChar = '*';
            this.tBPass.Size = new System.Drawing.Size(153, 23);
            this.tBPass.TabIndex = 31;
            // 
            // tBUser
            // 
            this.tBUser.BackColor = System.Drawing.Color.White;
            this.tBUser.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBUser.ForeColor = System.Drawing.Color.Black;
            this.tBUser.Location = new System.Drawing.Point(91, 27);
            this.tBUser.Name = "tBUser";
            this.tBUser.Size = new System.Drawing.Size(153, 23);
            this.tBUser.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(5, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 29;
            this.label2.Text = "Username:";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(11, 113);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(40, 15);
            this.lblInfo.TabIndex = 36;
            this.lblInfo.Text = "label4";
            // 
            // logFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 136);
            this.Controls.Add(this.paneMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "logFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.logFrm_Load);
            this.paneMain.ResumeLayout(false);
            this.paneMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBPass;
        private System.Windows.Forms.TextBox tBUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblInfo;
    }
}