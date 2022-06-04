
namespace POEPart2
{
    partial class BudgetApplication
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BudgetApplication));
            this.lbTitle = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtExpenses = new System.Windows.Forms.TextBox();
            this.txtIncome = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTravel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtWaterLights = new System.Windows.Forms.TextBox();
            this.txtGroceries = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUtilities = new System.Windows.Forms.Label();
            this.lbIncomeTax = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnHouse = new System.Windows.Forms.RadioButton();
            this.btnRent = new System.Windows.Forms.RadioButton();
            this.pnlHome = new System.Windows.Forms.Panel();
            this.txtNumOfMonths = new System.Windows.Forms.TextBox();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.txtDeposit = new System.Windows.Forms.TextBox();
            this.txtPurchasePrice = new System.Windows.Forms.TextBox();
            this.lbMonthRepay = new System.Windows.Forms.Label();
            this.lbInterestRate = new System.Windows.Forms.Label();
            this.lbTotalDeposit = new System.Windows.Forms.Label();
            this.lbPurchasePrice = new System.Windows.Forms.Label();
            this.pnlRent = new System.Windows.Forms.Panel();
            this.txtMonthRent = new System.Windows.Forms.TextBox();
            this.lbMonthRent = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCarinsurance = new System.Windows.Forms.TextBox();
            this.txtCarinterest = new System.Windows.Forms.TextBox();
            this.txtCardeposit = new System.Windows.Forms.TextBox();
            this.txtCarPrice = new System.Windows.Forms.TextBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.pnlHome.SuspendLayout();
            this.pnlRent.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTitle.Location = new System.Drawing.Point(134, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(553, 46);
            this.lbTitle.TabIndex = 4;
            this.lbTitle.Text = "Budget for Income and Expenditure";
            this.lbTitle.Click += new System.EventHandler(this.lbTitle_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(127, 74);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(573, 406);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(565, 378);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Description";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(-4, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(573, 435);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.lbIncomeTax);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(565, 378);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Income and Expenses";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtExpenses);
            this.panel2.Controls.Add(this.txtIncome);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtPhone);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtTravel);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtWaterLights);
            this.panel2.Controls.Add(this.txtGroceries);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtUtilities);
            this.panel2.Location = new System.Drawing.Point(3, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(559, 335);
            this.panel2.TabIndex = 8;
            // 
            // txtExpenses
            // 
            this.txtExpenses.Location = new System.Drawing.Point(141, 247);
            this.txtExpenses.Name = "txtExpenses";
            this.txtExpenses.Size = new System.Drawing.Size(100, 23);
            this.txtExpenses.TabIndex = 11;
            // 
            // txtIncome
            // 
            this.txtIncome.Location = new System.Drawing.Point(141, 48);
            this.txtIncome.Name = "txtIncome";
            this.txtIncome.Size = new System.Drawing.Size(100, 23);
            this.txtIncome.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Other expenses:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(141, 208);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 23);
            this.txtPhone.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Income:";
            // 
            // txtTravel
            // 
            this.txtTravel.Location = new System.Drawing.Point(141, 169);
            this.txtTravel.Name = "txtTravel";
            this.txtTravel.Size = new System.Drawing.Size(100, 23);
            this.txtTravel.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cellphone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Groceries:";
            // 
            // txtWaterLights
            // 
            this.txtWaterLights.Location = new System.Drawing.Point(141, 128);
            this.txtWaterLights.Name = "txtWaterLights";
            this.txtWaterLights.Size = new System.Drawing.Size(100, 23);
            this.txtWaterLights.TabIndex = 8;
            // 
            // txtGroceries
            // 
            this.txtGroceries.Location = new System.Drawing.Point(141, 89);
            this.txtGroceries.Name = "txtGroceries";
            this.txtGroceries.Size = new System.Drawing.Size(100, 23);
            this.txtGroceries.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Travel costs:";
            // 
            // txtUtilities
            // 
            this.txtUtilities.AutoSize = true;
            this.txtUtilities.Location = new System.Drawing.Point(10, 131);
            this.txtUtilities.Name = "txtUtilities";
            this.txtUtilities.Size = new System.Drawing.Size(46, 15);
            this.txtUtilities.TabIndex = 3;
            this.txtUtilities.Text = "Utilities";
            // 
            // lbIncomeTax
            // 
            this.lbIncomeTax.AutoSize = true;
            this.lbIncomeTax.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbIncomeTax.Location = new System.Drawing.Point(144, 9);
            this.lbIncomeTax.Name = "lbIncomeTax";
            this.lbIncomeTax.Size = new System.Drawing.Size(223, 28);
            this.lbIncomeTax.TabIndex = 0;
            this.lbIncomeTax.Text = "Income and Expenidture";
            this.lbIncomeTax.Click += new System.EventHandler(this.lbIncomeTax_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Transparent;
            this.tabPage3.Controls.Add(this.btnHouse);
            this.tabPage3.Controls.Add(this.btnRent);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.pnlHome);
            this.tabPage3.Controls.Add(this.pnlRent);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(565, 378);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Living Expenses";
            // 
            // btnHouse
            // 
            this.btnHouse.AutoSize = true;
            this.btnHouse.Location = new System.Drawing.Point(352, 78);
            this.btnHouse.Name = "btnHouse";
            this.btnHouse.Size = new System.Drawing.Size(128, 19);
            this.btnHouse.TabIndex = 8;
            this.btnHouse.TabStop = true;
            this.btnHouse.Text = "Purchasing a house";
            this.btnHouse.UseVisualStyleBackColor = true;
            this.btnHouse.CheckedChanged += new System.EventHandler(this.btnHouse_CheckedChanged);
            // 
            // btnRent
            // 
            this.btnRent.AutoSize = true;
            this.btnRent.Location = new System.Drawing.Point(71, 81);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(66, 19);
            this.btnRent.TabIndex = 7;
            this.btnRent.TabStop = true;
            this.btnRent.Text = "Renting";
            this.btnRent.UseVisualStyleBackColor = true;
            this.btnRent.CheckedChanged += new System.EventHandler(this.btnRent_CheckedChanged);
            // 
            // pnlHome
            // 
            this.pnlHome.Controls.Add(this.txtNumOfMonths);
            this.pnlHome.Controls.Add(this.txtInterestRate);
            this.pnlHome.Controls.Add(this.txtDeposit);
            this.pnlHome.Controls.Add(this.txtPurchasePrice);
            this.pnlHome.Controls.Add(this.lbMonthRepay);
            this.pnlHome.Controls.Add(this.lbInterestRate);
            this.pnlHome.Controls.Add(this.lbTotalDeposit);
            this.pnlHome.Controls.Add(this.lbPurchasePrice);
            this.pnlHome.Enabled = false;
            this.pnlHome.Location = new System.Drawing.Point(243, 121);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(322, 226);
            this.pnlHome.TabIndex = 5;
            this.pnlHome.Visible = false;
            // 
            // txtNumOfMonths
            // 
            this.txtNumOfMonths.Location = new System.Drawing.Point(206, 178);
            this.txtNumOfMonths.Name = "txtNumOfMonths";
            this.txtNumOfMonths.Size = new System.Drawing.Size(86, 23);
            this.txtNumOfMonths.TabIndex = 7;
            this.txtNumOfMonths.Text = "1";
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.Location = new System.Drawing.Point(205, 138);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(87, 23);
            this.txtInterestRate.TabIndex = 6;
            this.txtInterestRate.Text = "0";
            // 
            // txtDeposit
            // 
            this.txtDeposit.Location = new System.Drawing.Point(205, 95);
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.Size = new System.Drawing.Size(86, 23);
            this.txtDeposit.TabIndex = 5;
            this.txtDeposit.Text = "0";
            // 
            // txtPurchasePrice
            // 
            this.txtPurchasePrice.Location = new System.Drawing.Point(204, 54);
            this.txtPurchasePrice.Name = "txtPurchasePrice";
            this.txtPurchasePrice.Size = new System.Drawing.Size(87, 23);
            this.txtPurchasePrice.TabIndex = 4;
            this.txtPurchasePrice.Text = "0";
            // 
            // lbMonthRepay
            // 
            this.lbMonthRepay.AutoSize = true;
            this.lbMonthRepay.Location = new System.Drawing.Point(8, 181);
            this.lbMonthRepay.Name = "lbMonthRepay";
            this.lbMonthRepay.Size = new System.Drawing.Size(115, 15);
            this.lbMonthRepay.TabIndex = 3;
            this.lbMonthRepay.Text = "Monthly repayment:";
            // 
            // lbInterestRate
            // 
            this.lbInterestRate.AutoSize = true;
            this.lbInterestRate.Location = new System.Drawing.Point(8, 138);
            this.lbInterestRate.Name = "lbInterestRate";
            this.lbInterestRate.Size = new System.Drawing.Size(72, 15);
            this.lbInterestRate.TabIndex = 2;
            this.lbInterestRate.Text = "Interest rate:";
            // 
            // lbTotalDeposit
            // 
            this.lbTotalDeposit.AutoSize = true;
            this.lbTotalDeposit.Location = new System.Drawing.Point(8, 95);
            this.lbTotalDeposit.Name = "lbTotalDeposit";
            this.lbTotalDeposit.Size = new System.Drawing.Size(77, 15);
            this.lbTotalDeposit.TabIndex = 1;
            this.lbTotalDeposit.Text = "Total deposit:";
            // 
            // lbPurchasePrice
            // 
            this.lbPurchasePrice.AutoSize = true;
            this.lbPurchasePrice.Location = new System.Drawing.Point(8, 54);
            this.lbPurchasePrice.Name = "lbPurchasePrice";
            this.lbPurchasePrice.Size = new System.Drawing.Size(87, 15);
            this.lbPurchasePrice.TabIndex = 0;
            this.lbPurchasePrice.Text = "Purchase price:";
            // 
            // pnlRent
            // 
            this.pnlRent.Controls.Add(this.txtMonthRent);
            this.pnlRent.Controls.Add(this.lbMonthRent);
            this.pnlRent.Enabled = false;
            this.pnlRent.Location = new System.Drawing.Point(3, 123);
            this.pnlRent.Name = "pnlRent";
            this.pnlRent.Size = new System.Drawing.Size(222, 226);
            this.pnlRent.TabIndex = 4;
            this.pnlRent.Visible = false;
            // 
            // txtMonthRent
            // 
            this.txtMonthRent.Location = new System.Drawing.Point(47, 54);
            this.txtMonthRent.Name = "txtMonthRent";
            this.txtMonthRent.Size = new System.Drawing.Size(100, 23);
            this.txtMonthRent.TabIndex = 7;
            this.txtMonthRent.Text = "0";
            // 
            // lbMonthRent
            // 
            this.lbMonthRent.AutoSize = true;
            this.lbMonthRent.Location = new System.Drawing.Point(28, 24);
            this.lbMonthRent.Name = "lbMonthRent";
            this.lbMonthRent.Size = new System.Drawing.Size(154, 15);
            this.lbMonthRent.TabIndex = 6;
            this.lbMonthRent.Text = "Enter monthly rent amount:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(190, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Accomadation";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Transparent;
            this.tabPage4.Controls.Add(this.btnSubmit);
            this.tabPage4.Controls.Add(this.btnClear);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.panel1);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(565, 378);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Vehicle Exspenses";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(351, 350);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(160, 350);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(198, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "Vehicle Expenses";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtCarinsurance);
            this.panel1.Controls.Add(this.txtCarinterest);
            this.panel1.Controls.Add(this.txtCardeposit);
            this.panel1.Controls.Add(this.txtCarPrice);
            this.panel1.Controls.Add(this.txtMake);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(42, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(462, 277);
            this.panel1.TabIndex = 3;
            // 
            // txtCarinsurance
            // 
            this.txtCarinsurance.Location = new System.Drawing.Point(276, 236);
            this.txtCarinsurance.Name = "txtCarinsurance";
            this.txtCarinsurance.Size = new System.Drawing.Size(100, 23);
            this.txtCarinsurance.TabIndex = 14;
            this.txtCarinsurance.Text = "0";
            // 
            // txtCarinterest
            // 
            this.txtCarinterest.Location = new System.Drawing.Point(276, 182);
            this.txtCarinterest.Name = "txtCarinterest";
            this.txtCarinterest.Size = new System.Drawing.Size(100, 23);
            this.txtCarinterest.TabIndex = 13;
            this.txtCarinterest.Text = "0";
            // 
            // txtCardeposit
            // 
            this.txtCardeposit.Location = new System.Drawing.Point(276, 131);
            this.txtCardeposit.Name = "txtCardeposit";
            this.txtCardeposit.Size = new System.Drawing.Size(100, 23);
            this.txtCardeposit.TabIndex = 12;
            this.txtCardeposit.Text = "0";
            // 
            // txtCarPrice
            // 
            this.txtCarPrice.Location = new System.Drawing.Point(276, 83);
            this.txtCarPrice.Name = "txtCarPrice";
            this.txtCarPrice.Size = new System.Drawing.Size(100, 23);
            this.txtCarPrice.TabIndex = 11;
            this.txtCarPrice.Text = "0";
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(276, 29);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(100, 23);
            this.txtMake.TabIndex = 10;
            this.txtMake.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(51, 236);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(171, 15);
            this.label13.TabIndex = 9;
            this.label13.Text = "Estimated insurance premium: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(51, 182);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 15);
            this.label12.TabIndex = 8;
            this.label12.Text = "Interest rate (%): ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(51, 131);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 15);
            this.label11.TabIndex = 7;
            this.label11.Text = "Total deposit: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(51, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 15);
            this.label9.TabIndex = 6;
            this.label9.Text = "Purchase price:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(51, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "Make and model:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(397, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "**A value between 240 and 360 must be selected for monthly repayment**\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // BudgetApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 545);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lbTitle);
            this.Name = "BudgetApplication";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.pnlHome.ResumeLayout(false);
            this.pnlHome.PerformLayout();
            this.pnlRent.ResumeLayout(false);
            this.pnlRent.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbIncomeTax;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtIncome;
        private System.Windows.Forms.TextBox txtExpenses;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtTravel;
        private System.Windows.Forms.TextBox txtWaterLights;
        private System.Windows.Forms.TextBox txtGroceries;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtUtilities;
        private System.Windows.Forms.Panel pnlHome;
        private System.Windows.Forms.Panel pnlRent;
        private System.Windows.Forms.TextBox txtNumOfMonths;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.TextBox txtDeposit;
        private System.Windows.Forms.TextBox txtPurchasePrice;
        private System.Windows.Forms.Label lbMonthRepay;
        private System.Windows.Forms.Label lbInterestRate;
        private System.Windows.Forms.Label lbTotalDeposit;
        private System.Windows.Forms.Label lbPurchasePrice;
        private System.Windows.Forms.TextBox txtMonthRent;
        private System.Windows.Forms.Label lbMonthRent;
        private System.Windows.Forms.RadioButton btnHouse;
        private System.Windows.Forms.RadioButton btnRent;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCarinsurance;
        private System.Windows.Forms.TextBox txtCarinterest;
        private System.Windows.Forms.TextBox txtCardeposit;
        private System.Windows.Forms.TextBox txtCarPrice;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label2;
    }
}

