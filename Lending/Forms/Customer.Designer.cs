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
            this.PaneTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PBLogo = new System.Windows.Forms.PictureBox();
            this.BTNClose = new System.Windows.Forms.Button();
            this.btnToggle = new System.Windows.Forms.Button();
            this.PaneAdd = new System.Windows.Forms.FlowLayoutPanel();
            this.tBZip = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tBStreet = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cBBar = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cBMun = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cBProvince = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cBCountry = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Div1 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tBFirstName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.PaneMain = new System.Windows.Forms.Panel();
            this.btnAdd_Cust = new System.Windows.Forms.Button();
            this.Div2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.dTDOB = new System.Windows.Forms.DateTimePicker();
            this.pBCust = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.PaneTable = new System.Windows.Forms.Panel();
            this.PaneTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).BeginInit();
            this.PaneAdd.SuspendLayout();
            this.PaneMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBCust)).BeginInit();
            this.SuspendLayout();
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
            // btnToggle
            // 
            this.btnToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToggle.Location = new System.Drawing.Point(265, 366);
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnToggle.Size = new System.Drawing.Size(40, 98);
            this.btnToggle.TabIndex = 3;
            this.btnToggle.Text = "NEW";
            this.btnToggle.UseVisualStyleBackColor = true;
            this.btnToggle.Click += new System.EventHandler(this.btnToggle_Click);
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
            this.PaneAdd.Controls.Add(this.label5);
            this.PaneAdd.Controls.Add(this.dTDOB);
            this.PaneAdd.Controls.Add(this.Div1);
            this.PaneAdd.Controls.Add(this.label11);
            this.PaneAdd.Controls.Add(this.cBCountry);
            this.PaneAdd.Controls.Add(this.label6);
            this.PaneAdd.Controls.Add(this.cBProvince);
            this.PaneAdd.Controls.Add(this.label7);
            this.PaneAdd.Controls.Add(this.cBMun);
            this.PaneAdd.Controls.Add(this.label10);
            this.PaneAdd.Controls.Add(this.cBBar);
            this.PaneAdd.Controls.Add(this.label9);
            this.PaneAdd.Controls.Add(this.tBStreet);
            this.PaneAdd.Controls.Add(this.label8);
            this.PaneAdd.Controls.Add(this.tBZip);
            this.PaneAdd.Controls.Add(this.Div2);
            this.PaneAdd.Controls.Add(this.pBCust);
            this.PaneAdd.Controls.Add(this.button1);
            this.PaneAdd.Controls.Add(this.panel1);
            this.PaneAdd.Controls.Add(this.btnAdd_Cust);
            this.PaneAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.PaneAdd.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.PaneAdd.Location = new System.Drawing.Point(0, 42);
            this.PaneAdd.Name = "PaneAdd";
            this.PaneAdd.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.PaneAdd.Size = new System.Drawing.Size(263, 958);
            this.PaneAdd.TabIndex = 4;
            this.PaneAdd.Visible = false;
            // 
            // tBZip
            // 
            this.tBZip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBZip.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBZip.ForeColor = System.Drawing.Color.Black;
            this.tBZip.Location = new System.Drawing.Point(10, 738);
            this.tBZip.MaxLength = 10;
            this.tBZip.Name = "tBZip";
            this.tBZip.Size = new System.Drawing.Size(248, 34);
            this.tBZip.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(165, 707);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 28);
            this.label8.TabIndex = 13;
            this.label8.Text = "ZipCode:";
            // 
            // tBStreet
            // 
            this.tBStreet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBStreet.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBStreet.ForeColor = System.Drawing.Color.Black;
            this.tBStreet.Location = new System.Drawing.Point(10, 670);
            this.tBStreet.MaxLength = 200;
            this.tBStreet.Name = "tBStreet";
            this.tBStreet.Size = new System.Drawing.Size(248, 34);
            this.tBStreet.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(52, 646);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(206, 21);
            this.label9.TabIndex = 15;
            this.label9.Text = "Street/HouseNo./Building:";
            // 
            // cBBar
            // 
            this.cBBar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBBar.FormattingEnabled = true;
            this.cBBar.Location = new System.Drawing.Point(10, 607);
            this.cBBar.Name = "cBBar";
            this.cBBar.Size = new System.Drawing.Size(248, 36);
            this.cBBar.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(158, 576);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 28);
            this.label10.TabIndex = 16;
            this.label10.Text = "Barangay:";
            // 
            // cBMun
            // 
            this.cBMun.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBMun.FormattingEnabled = true;
            this.cBMun.Location = new System.Drawing.Point(10, 537);
            this.cBMun.Name = "cBMun";
            this.cBMun.Size = new System.Drawing.Size(248, 36);
            this.cBMun.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(131, 506);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 28);
            this.label7.TabIndex = 11;
            this.label7.Text = "Municipality:";
            // 
            // cBProvince
            // 
            this.cBProvince.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBProvince.FormattingEnabled = true;
            this.cBProvince.Location = new System.Drawing.Point(10, 467);
            this.cBProvince.Name = "cBProvince";
            this.cBProvince.Size = new System.Drawing.Size(248, 36);
            this.cBProvince.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(163, 436);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 28);
            this.label6.TabIndex = 9;
            this.label6.Text = "Province:";
            // 
            // cBCountry
            // 
            this.cBCountry.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBCountry.FormattingEnabled = true;
            this.cBCountry.Location = new System.Drawing.Point(10, 397);
            this.cBCountry.Name = "cBCountry";
            this.cBCountry.Size = new System.Drawing.Size(248, 36);
            this.cBCountry.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(168, 366);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 28);
            this.label11.TabIndex = 7;
            this.label11.Text = "Country:";
            // 
            // Div1
            // 
            this.Div1.BackColor = System.Drawing.Color.Black;
            this.Div1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Div1.Location = new System.Drawing.Point(-5, 360);
            this.Div1.Name = "Div1";
            this.Div1.Size = new System.Drawing.Size(263, 3);
            this.Div1.TabIndex = 19;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.Black;
            this.textBox3.Location = new System.Drawing.Point(10, 255);
            this.textBox3.MaxLength = 200;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(248, 34);
            this.textBox3.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(178, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 28);
            this.label4.TabIndex = 16;
            this.label4.Text = "Mobile:";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(10, 187);
            this.textBox2.MaxLength = 200;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(248, 34);
            this.textBox2.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(193, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 28);
            this.label3.TabIndex = 14;
            this.label3.Text = "Email:";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(10, 119);
            this.textBox1.MaxLength = 200;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(248, 34);
            this.textBox1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(145, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 28);
            this.label2.TabIndex = 12;
            this.label2.Text = "Last Name:";
            // 
            // tBFirstName
            // 
            this.tBFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBFirstName.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBFirstName.ForeColor = System.Drawing.Color.Black;
            this.tBFirstName.Location = new System.Drawing.Point(10, 51);
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
            this.label12.Location = new System.Drawing.Point(143, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 28);
            this.label12.TabIndex = 10;
            this.label12.Text = "First Name:";
            // 
            // PaneMain
            // 
            this.PaneMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PaneMain.Controls.Add(this.PaneTable);
            this.PaneMain.Controls.Add(this.PaneAdd);
            this.PaneMain.Controls.Add(this.btnToggle);
            this.PaneMain.Controls.Add(this.PaneTop);
            this.PaneMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PaneMain.Location = new System.Drawing.Point(0, 0);
            this.PaneMain.Name = "PaneMain";
            this.PaneMain.Size = new System.Drawing.Size(1114, 1002);
            this.PaneMain.TabIndex = 0;
            // 
            // btnAdd_Cust
            // 
            this.btnAdd_Cust.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd_Cust.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnAdd_Cust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd_Cust.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd_Cust.ForeColor = System.Drawing.Color.Black;
            this.btnAdd_Cust.Location = new System.Drawing.Point(10, 910);
            this.btnAdd_Cust.Name = "btnAdd_Cust";
            this.btnAdd_Cust.Size = new System.Drawing.Size(248, 39);
            this.btnAdd_Cust.TabIndex = 5;
            this.btnAdd_Cust.Text = "Add New Customer";
            this.btnAdd_Cust.UseVisualStyleBackColor = true;
            // 
            // Div2
            // 
            this.Div2.BackColor = System.Drawing.Color.Black;
            this.Div2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Div2.Location = new System.Drawing.Point(-5, 778);
            this.Div2.Name = "Div2";
            this.Div2.Size = new System.Drawing.Size(263, 3);
            this.Div2.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(124, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 28);
            this.label5.TabIndex = 18;
            this.label5.Text = "Date of Birth:";
            // 
            // dTDOB
            // 
            this.dTDOB.CustomFormat = "yyyy-MM-dd";
            this.dTDOB.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dTDOB.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTDOB.Location = new System.Drawing.Point(10, 323);
            this.dTDOB.Name = "dTDOB";
            this.dTDOB.Size = new System.Drawing.Size(248, 31);
            this.dTDOB.TabIndex = 19;
            // 
            // pBCust
            // 
            this.pBCust.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBCust.Location = new System.Drawing.Point(142, 787);
            this.pBCust.Name = "pBCust";
            this.pBCust.Size = new System.Drawing.Size(116, 108);
            this.pBCust.TabIndex = 6;
            this.pBCust.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(-5, 901);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 3);
            this.panel1.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(10, 787);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 39);
            this.button1.TabIndex = 6;
            this.button1.Text = "Upload Photo:";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // PaneTable
            // 
            this.PaneTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PaneTable.Dock = System.Windows.Forms.DockStyle.Right;
            this.PaneTable.Location = new System.Drawing.Point(311, 42);
            this.PaneTable.Name = "PaneTable";
            this.PaneTable.Size = new System.Drawing.Size(801, 958);
            this.PaneTable.TabIndex = 5;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1114, 1002);
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
            this.PaneTop.ResumeLayout(false);
            this.PaneTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).EndInit();
            this.PaneAdd.ResumeLayout(false);
            this.PaneAdd.PerformLayout();
            this.PaneMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBCust)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

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
        private System.Windows.Forms.Panel Div1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cBCountry;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cBProvince;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cBMun;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cBBar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tBStreet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tBZip;
        private System.Windows.Forms.Panel PaneMain;
        private System.Windows.Forms.Button btnAdd_Cust;
        private System.Windows.Forms.Panel Div2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dTDOB;
        private System.Windows.Forms.PictureBox pBCust;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel PaneTable;
    }
}