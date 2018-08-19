namespace BankingAPP
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.home = new System.Windows.Forms.TabPage();
            this.calculate = new System.Windows.Forms.Button();
            this.buttonTransactionHOME = new System.Windows.Forms.Button();
            this.buttonAddHOME = new System.Windows.Forms.Button();
            this.buttonSearchHOME = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.TabPage();
            this.textBoxLNameSEARCH = new System.Windows.Forms.TextBox();
            this.textBoxFNameSEARCH = new System.Windows.Forms.TextBox();
            this.labelLNameSEARCH = new System.Windows.Forms.Label();
            this.labelFNameSEARCH = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonHomeSEARCH = new System.Windows.Forms.Button();
            this.buttonSearchSEARCH = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.TabPage();
            this.textBoxInterestRateADD = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonHomeADD = new System.Windows.Forms.Button();
            this.buttonAddADD = new System.Windows.Forms.Button();
            this.textBoxBalanceADD = new System.Windows.Forms.TextBox();
            this.textBoxAccNumADD = new System.Windows.Forms.TextBox();
            this.textBoxPhoneADD = new System.Windows.Forms.TextBox();
            this.textBoxAddressADD = new System.Windows.Forms.TextBox();
            this.textBoxNameADD = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.transaction = new System.Windows.Forms.TabPage();
            this.textBoxAccountNumTRANS = new System.Windows.Forms.TextBox();
            this.textBoxAmountTRANS = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonHomeTRANS = new System.Windows.Forms.Button();
            this.buttonWithdrawTRANS = new System.Windows.Forms.Button();
            this.buttonDepostTRANS = new System.Windows.Forms.Button();
            this.calc = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxMonthCALC = new System.Windows.Forms.TextBox();
            this.textBoxAccountNumCALC = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.buttonCalcCALC = new System.Windows.Forms.Button();
            this.buttonHomeCALC = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.home.SuspendLayout();
            this.search.SuspendLayout();
            this.add.SuspendLayout();
            this.transaction.SuspendLayout();
            this.calc.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.home);
            this.tabControl1.Controls.Add(this.search);
            this.tabControl1.Controls.Add(this.add);
            this.tabControl1.Controls.Add(this.transaction);
            this.tabControl1.Controls.Add(this.calc);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(242, 299);
            this.tabControl1.TabIndex = 0;
            // 
            // home
            // 
            this.home.Controls.Add(this.calculate);
            this.home.Controls.Add(this.buttonTransactionHOME);
            this.home.Controls.Add(this.buttonAddHOME);
            this.home.Controls.Add(this.buttonSearchHOME);
            this.home.Controls.Add(this.label1);
            this.home.Location = new System.Drawing.Point(4, 4);
            this.home.Name = "home";
            this.home.Padding = new System.Windows.Forms.Padding(3);
            this.home.Size = new System.Drawing.Size(234, 273);
            this.home.TabIndex = 0;
            this.home.Text = "home";
            this.home.UseVisualStyleBackColor = true;
            // 
            // calculate
            // 
            this.calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculate.Location = new System.Drawing.Point(43, 212);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(150, 50);
            this.calculate.TabIndex = 5;
            this.calculate.Text = "Calculate Interest";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // buttonTransactionHOME
            // 
            this.buttonTransactionHOME.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTransactionHOME.Location = new System.Drawing.Point(43, 156);
            this.buttonTransactionHOME.Name = "buttonTransactionHOME";
            this.buttonTransactionHOME.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonTransactionHOME.Size = new System.Drawing.Size(150, 50);
            this.buttonTransactionHOME.TabIndex = 4;
            this.buttonTransactionHOME.Text = "Deposit or Withdraw";
            this.buttonTransactionHOME.UseVisualStyleBackColor = true;
            this.buttonTransactionHOME.Click += new System.EventHandler(this.buttonTransactionHOME_Click);
            // 
            // buttonAddHOME
            // 
            this.buttonAddHOME.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddHOME.Location = new System.Drawing.Point(43, 100);
            this.buttonAddHOME.Name = "buttonAddHOME";
            this.buttonAddHOME.Size = new System.Drawing.Size(150, 50);
            this.buttonAddHOME.TabIndex = 2;
            this.buttonAddHOME.Text = "Add Customer";
            this.buttonAddHOME.UseVisualStyleBackColor = true;
            this.buttonAddHOME.Click += new System.EventHandler(this.buttonAddHOME_Click);
            // 
            // buttonSearchHOME
            // 
            this.buttonSearchHOME.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchHOME.Location = new System.Drawing.Point(43, 44);
            this.buttonSearchHOME.Name = "buttonSearchHOME";
            this.buttonSearchHOME.Size = new System.Drawing.Size(150, 50);
            this.buttonSearchHOME.TabIndex = 1;
            this.buttonSearchHOME.Text = "Search Customer";
            this.buttonSearchHOME.UseVisualStyleBackColor = true;
            this.buttonSearchHOME.Click += new System.EventHandler(this.buttonSearchHOME_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Banking Application Home";
            // 
            // search
            // 
            this.search.Controls.Add(this.textBoxLNameSEARCH);
            this.search.Controls.Add(this.textBoxFNameSEARCH);
            this.search.Controls.Add(this.labelLNameSEARCH);
            this.search.Controls.Add(this.labelFNameSEARCH);
            this.search.Controls.Add(this.label2);
            this.search.Controls.Add(this.buttonHomeSEARCH);
            this.search.Controls.Add(this.buttonSearchSEARCH);
            this.search.Location = new System.Drawing.Point(4, 4);
            this.search.Name = "search";
            this.search.Padding = new System.Windows.Forms.Padding(3);
            this.search.Size = new System.Drawing.Size(234, 273);
            this.search.TabIndex = 1;
            this.search.Text = "search";
            this.search.UseVisualStyleBackColor = true;
            // 
            // textBoxLNameSEARCH
            // 
            this.textBoxLNameSEARCH.Location = new System.Drawing.Point(98, 137);
            this.textBoxLNameSEARCH.Name = "textBoxLNameSEARCH";
            this.textBoxLNameSEARCH.Size = new System.Drawing.Size(100, 20);
            this.textBoxLNameSEARCH.TabIndex = 6;
            this.textBoxLNameSEARCH.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxLNameSEARCH_MouseClick);
            // 
            // textBoxFNameSEARCH
            // 
            this.textBoxFNameSEARCH.Location = new System.Drawing.Point(98, 97);
            this.textBoxFNameSEARCH.Name = "textBoxFNameSEARCH";
            this.textBoxFNameSEARCH.Size = new System.Drawing.Size(100, 20);
            this.textBoxFNameSEARCH.TabIndex = 5;
            this.textBoxFNameSEARCH.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxFNameSEARCH_MouseClick);
            // 
            // labelLNameSEARCH
            // 
            this.labelLNameSEARCH.AutoSize = true;
            this.labelLNameSEARCH.Location = new System.Drawing.Point(32, 140);
            this.labelLNameSEARCH.Name = "labelLNameSEARCH";
            this.labelLNameSEARCH.Size = new System.Drawing.Size(61, 13);
            this.labelLNameSEARCH.TabIndex = 4;
            this.labelLNameSEARCH.Text = "Last Name:";
            // 
            // labelFNameSEARCH
            // 
            this.labelFNameSEARCH.AutoSize = true;
            this.labelFNameSEARCH.Location = new System.Drawing.Point(32, 100);
            this.labelFNameSEARCH.Name = "labelFNameSEARCH";
            this.labelFNameSEARCH.Size = new System.Drawing.Size(60, 13);
            this.labelFNameSEARCH.TabIndex = 3;
            this.labelFNameSEARCH.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Search Customer by Name";
            // 
            // buttonHomeSEARCH
            // 
            this.buttonHomeSEARCH.Location = new System.Drawing.Point(156, 228);
            this.buttonHomeSEARCH.Name = "buttonHomeSEARCH";
            this.buttonHomeSEARCH.Size = new System.Drawing.Size(75, 23);
            this.buttonHomeSEARCH.TabIndex = 1;
            this.buttonHomeSEARCH.Text = "Done";
            this.buttonHomeSEARCH.UseVisualStyleBackColor = true;
            this.buttonHomeSEARCH.Click += new System.EventHandler(this.buttonHomeSEARCH_Click);
            // 
            // buttonSearchSEARCH
            // 
            this.buttonSearchSEARCH.Location = new System.Drawing.Point(78, 177);
            this.buttonSearchSEARCH.Name = "buttonSearchSEARCH";
            this.buttonSearchSEARCH.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchSEARCH.TabIndex = 0;
            this.buttonSearchSEARCH.Text = "Search";
            this.buttonSearchSEARCH.UseVisualStyleBackColor = true;
            this.buttonSearchSEARCH.Click += new System.EventHandler(this.buttonSearchSEARCH_Click);
            // 
            // add
            // 
            this.add.Controls.Add(this.textBoxInterestRateADD);
            this.add.Controls.Add(this.label12);
            this.add.Controls.Add(this.buttonHomeADD);
            this.add.Controls.Add(this.buttonAddADD);
            this.add.Controls.Add(this.textBoxBalanceADD);
            this.add.Controls.Add(this.textBoxAccNumADD);
            this.add.Controls.Add(this.textBoxPhoneADD);
            this.add.Controls.Add(this.textBoxAddressADD);
            this.add.Controls.Add(this.textBoxNameADD);
            this.add.Controls.Add(this.label8);
            this.add.Controls.Add(this.label7);
            this.add.Controls.Add(this.label6);
            this.add.Controls.Add(this.label5);
            this.add.Controls.Add(this.label4);
            this.add.Controls.Add(this.label3);
            this.add.Location = new System.Drawing.Point(4, 4);
            this.add.Name = "add";
            this.add.Padding = new System.Windows.Forms.Padding(3);
            this.add.Size = new System.Drawing.Size(234, 273);
            this.add.TabIndex = 2;
            this.add.Text = "add";
            this.add.UseVisualStyleBackColor = true;
            // 
            // textBoxInterestRateADD
            // 
            this.textBoxInterestRateADD.Location = new System.Drawing.Point(108, 171);
            this.textBoxInterestRateADD.Name = "textBoxInterestRateADD";
            this.textBoxInterestRateADD.Size = new System.Drawing.Size(100, 20);
            this.textBoxInterestRateADD.TabIndex = 14;
            this.textBoxInterestRateADD.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxInterestRateADD_MouseClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(33, 174);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Interest Rate:";
            // 
            // buttonHomeADD
            // 
            this.buttonHomeADD.Location = new System.Drawing.Point(156, 228);
            this.buttonHomeADD.Name = "buttonHomeADD";
            this.buttonHomeADD.Size = new System.Drawing.Size(75, 23);
            this.buttonHomeADD.TabIndex = 12;
            this.buttonHomeADD.Text = "Done";
            this.buttonHomeADD.UseVisualStyleBackColor = true;
            this.buttonHomeADD.Click += new System.EventHandler(this.buttonHomeADD_Click);
            // 
            // buttonAddADD
            // 
            this.buttonAddADD.Location = new System.Drawing.Point(56, 228);
            this.buttonAddADD.Name = "buttonAddADD";
            this.buttonAddADD.Size = new System.Drawing.Size(94, 23);
            this.buttonAddADD.TabIndex = 11;
            this.buttonAddADD.Text = "Add Customer";
            this.buttonAddADD.UseVisualStyleBackColor = true;
            this.buttonAddADD.Click += new System.EventHandler(this.buttonAddADD_Click);
            // 
            // textBoxBalanceADD
            // 
            this.textBoxBalanceADD.Location = new System.Drawing.Point(108, 145);
            this.textBoxBalanceADD.Name = "textBoxBalanceADD";
            this.textBoxBalanceADD.Size = new System.Drawing.Size(100, 20);
            this.textBoxBalanceADD.TabIndex = 10;
            this.textBoxBalanceADD.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxBalanceADD_MouseClick);
            // 
            // textBoxAccNumADD
            // 
            this.textBoxAccNumADD.Location = new System.Drawing.Point(108, 119);
            this.textBoxAccNumADD.Name = "textBoxAccNumADD";
            this.textBoxAccNumADD.Size = new System.Drawing.Size(100, 20);
            this.textBoxAccNumADD.TabIndex = 9;
            this.textBoxAccNumADD.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxAccNumADD_MouseClick);
            // 
            // textBoxPhoneADD
            // 
            this.textBoxPhoneADD.Location = new System.Drawing.Point(108, 93);
            this.textBoxPhoneADD.Name = "textBoxPhoneADD";
            this.textBoxPhoneADD.Size = new System.Drawing.Size(100, 20);
            this.textBoxPhoneADD.TabIndex = 8;
            this.textBoxPhoneADD.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxPhoneADD_MouseClick);
            // 
            // textBoxAddressADD
            // 
            this.textBoxAddressADD.Location = new System.Drawing.Point(108, 67);
            this.textBoxAddressADD.Name = "textBoxAddressADD";
            this.textBoxAddressADD.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddressADD.TabIndex = 7;
            this.textBoxAddressADD.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxAddressADD_MouseClick);
            // 
            // textBoxNameADD
            // 
            this.textBoxNameADD.Location = new System.Drawing.Point(108, 41);
            this.textBoxNameADD.Name = "textBoxNameADD";
            this.textBoxNameADD.Size = new System.Drawing.Size(100, 20);
            this.textBoxNameADD.TabIndex = 6;
            this.textBoxNameADD.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxNameADD_MouseClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Starting Balance:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Account Number:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Phone Number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Customer Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Add New Customer";
            // 
            // transaction
            // 
            this.transaction.Controls.Add(this.textBoxAccountNumTRANS);
            this.transaction.Controls.Add(this.textBoxAmountTRANS);
            this.transaction.Controls.Add(this.label11);
            this.transaction.Controls.Add(this.label10);
            this.transaction.Controls.Add(this.label9);
            this.transaction.Controls.Add(this.buttonHomeTRANS);
            this.transaction.Controls.Add(this.buttonWithdrawTRANS);
            this.transaction.Controls.Add(this.buttonDepostTRANS);
            this.transaction.Location = new System.Drawing.Point(4, 4);
            this.transaction.Name = "transaction";
            this.transaction.Size = new System.Drawing.Size(234, 273);
            this.transaction.TabIndex = 4;
            this.transaction.Text = "trans";
            this.transaction.UseVisualStyleBackColor = true;
            // 
            // textBoxAccountNumTRANS
            // 
            this.textBoxAccountNumTRANS.Location = new System.Drawing.Point(104, 84);
            this.textBoxAccountNumTRANS.Name = "textBoxAccountNumTRANS";
            this.textBoxAccountNumTRANS.Size = new System.Drawing.Size(100, 20);
            this.textBoxAccountNumTRANS.TabIndex = 7;
            this.textBoxAccountNumTRANS.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxAccountNumTRANS_MouseClick);
            // 
            // textBoxAmountTRANS
            // 
            this.textBoxAmountTRANS.Location = new System.Drawing.Point(104, 120);
            this.textBoxAmountTRANS.Name = "textBoxAmountTRANS";
            this.textBoxAmountTRANS.Size = new System.Drawing.Size(100, 20);
            this.textBoxAmountTRANS.TabIndex = 6;
            this.textBoxAmountTRANS.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxAmountTRANS_MouseClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(52, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Amount: $";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Account Number:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(30, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(171, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Deposit or Withdraw";
            // 
            // buttonHomeTRANS
            // 
            this.buttonHomeTRANS.Location = new System.Drawing.Point(156, 228);
            this.buttonHomeTRANS.Name = "buttonHomeTRANS";
            this.buttonHomeTRANS.Size = new System.Drawing.Size(75, 23);
            this.buttonHomeTRANS.TabIndex = 2;
            this.buttonHomeTRANS.Text = "Done";
            this.buttonHomeTRANS.UseVisualStyleBackColor = true;
            this.buttonHomeTRANS.Click += new System.EventHandler(this.buttonHomeTRANS_Click);
            // 
            // buttonWithdrawTRANS
            // 
            this.buttonWithdrawTRANS.Location = new System.Drawing.Point(126, 166);
            this.buttonWithdrawTRANS.Name = "buttonWithdrawTRANS";
            this.buttonWithdrawTRANS.Size = new System.Drawing.Size(75, 23);
            this.buttonWithdrawTRANS.TabIndex = 1;
            this.buttonWithdrawTRANS.Text = "Withdraw";
            this.buttonWithdrawTRANS.UseVisualStyleBackColor = true;
            this.buttonWithdrawTRANS.Click += new System.EventHandler(this.buttonWithdrawTRANS_Click);
            // 
            // buttonDepostTRANS
            // 
            this.buttonDepostTRANS.Location = new System.Drawing.Point(23, 166);
            this.buttonDepostTRANS.Name = "buttonDepostTRANS";
            this.buttonDepostTRANS.Size = new System.Drawing.Size(75, 23);
            this.buttonDepostTRANS.TabIndex = 0;
            this.buttonDepostTRANS.Text = "Deposit";
            this.buttonDepostTRANS.UseVisualStyleBackColor = true;
            this.buttonDepostTRANS.Click += new System.EventHandler(this.buttonDepostTRANS_Click);
            // 
            // calc
            // 
            this.calc.Controls.Add(this.label15);
            this.calc.Controls.Add(this.textBoxMonthCALC);
            this.calc.Controls.Add(this.textBoxAccountNumCALC);
            this.calc.Controls.Add(this.label14);
            this.calc.Controls.Add(this.label13);
            this.calc.Controls.Add(this.buttonCalcCALC);
            this.calc.Controls.Add(this.buttonHomeCALC);
            this.calc.Location = new System.Drawing.Point(4, 4);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(234, 273);
            this.calc.TabIndex = 5;
            this.calc.Text = "calc";
            this.calc.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(39, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(152, 20);
            this.label15.TabIndex = 6;
            this.label15.Text = "Calculate Interest";
            // 
            // textBoxMonthCALC
            // 
            this.textBoxMonthCALC.Location = new System.Drawing.Point(111, 120);
            this.textBoxMonthCALC.Name = "textBoxMonthCALC";
            this.textBoxMonthCALC.Size = new System.Drawing.Size(100, 20);
            this.textBoxMonthCALC.TabIndex = 5;
            // 
            // textBoxAccountNumCALC
            // 
            this.textBoxAccountNumCALC.Location = new System.Drawing.Point(111, 81);
            this.textBoxAccountNumCALC.Name = "textBoxAccountNumCALC";
            this.textBoxAccountNumCALC.Size = new System.Drawing.Size(100, 20);
            this.textBoxAccountNumCALC.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(21, 123);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Month (number):";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 84);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Account Number:";
            // 
            // buttonCalcCALC
            // 
            this.buttonCalcCALC.Location = new System.Drawing.Point(131, 170);
            this.buttonCalcCALC.Name = "buttonCalcCALC";
            this.buttonCalcCALC.Size = new System.Drawing.Size(75, 23);
            this.buttonCalcCALC.TabIndex = 1;
            this.buttonCalcCALC.Text = "Calculate";
            this.buttonCalcCALC.UseVisualStyleBackColor = true;
            this.buttonCalcCALC.Click += new System.EventHandler(this.buttonCalcCALC_Click);
            // 
            // buttonHomeCALC
            // 
            this.buttonHomeCALC.Location = new System.Drawing.Point(156, 229);
            this.buttonHomeCALC.Name = "buttonHomeCALC";
            this.buttonHomeCALC.Size = new System.Drawing.Size(75, 23);
            this.buttonHomeCALC.TabIndex = 0;
            this.buttonHomeCALC.Text = "Done";
            this.buttonHomeCALC.UseVisualStyleBackColor = true;
            this.buttonHomeCALC.Click += new System.EventHandler(this.buttonHomeCALC_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 296);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.home.ResumeLayout(false);
            this.home.PerformLayout();
            this.search.ResumeLayout(false);
            this.search.PerformLayout();
            this.add.ResumeLayout(false);
            this.add.PerformLayout();
            this.transaction.ResumeLayout(false);
            this.transaction.PerformLayout();
            this.calc.ResumeLayout(false);
            this.calc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage home;
        private System.Windows.Forms.TabPage search;
        private System.Windows.Forms.Button buttonTransactionHOME;
        private System.Windows.Forms.Button buttonAddHOME;
        private System.Windows.Forms.Button buttonSearchHOME;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage add;
        private System.Windows.Forms.TabPage transaction;
        private System.Windows.Forms.TextBox textBoxLNameSEARCH;
        private System.Windows.Forms.TextBox textBoxFNameSEARCH;
        private System.Windows.Forms.Label labelLNameSEARCH;
        private System.Windows.Forms.Label labelFNameSEARCH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonHomeSEARCH;
        private System.Windows.Forms.Button buttonSearchSEARCH;
        private System.Windows.Forms.Button buttonHomeADD;
        private System.Windows.Forms.Button buttonAddADD;
        private System.Windows.Forms.TextBox textBoxBalanceADD;
        private System.Windows.Forms.TextBox textBoxAccNumADD;
        private System.Windows.Forms.TextBox textBoxPhoneADD;
        private System.Windows.Forms.TextBox textBoxAddressADD;
        private System.Windows.Forms.TextBox textBoxNameADD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAccountNumTRANS;
        private System.Windows.Forms.TextBox textBoxAmountTRANS;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonHomeTRANS;
        private System.Windows.Forms.Button buttonWithdrawTRANS;
        private System.Windows.Forms.Button buttonDepostTRANS;
        private System.Windows.Forms.TextBox textBoxInterestRateADD;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.TabPage calc;
        private System.Windows.Forms.TextBox textBoxMonthCALC;
        private System.Windows.Forms.TextBox textBoxAccountNumCALC;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button buttonCalcCALC;
        private System.Windows.Forms.Button buttonHomeCALC;
        private System.Windows.Forms.Label label15;
    }
}

