using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POEpart2;

namespace POEPart2
{
    public partial class BudgetApplication : Form 
    {
        #region Delegate declaration
        public class ErrorDelegate
        {
            public delegate void FirstDelegate();
            public void Error()
            {
                MessageBox.Show("Your total expenses is more than or equal to 75% of your income");
            }
        }
        #endregion

        ErrorDelegate errordelegate = new ErrorDelegate();
        public BudgetApplication()
        {
            InitializeComponent(); //Code to make the panels be invisible until selected
            pnlRent.Visible = false;
            pnlHome.Visible = false;
            pnlHome.Enabled = false;
            pnlRent.Enabled = false;
        }

        private void btnRent_CheckedChanged(object sender, EventArgs e) //When rent is selected the rent panel
        {                                                               //will be displayed
            pnlRent.Visible = true;
            pnlHome.Visible = false;
            pnlHome.Enabled = false;
            pnlRent.Enabled = true;
        }

        private void btnHouse_CheckedChanged(object sender, EventArgs e) // When house is selected the house 
        {                                                                //panel will be displayed
            pnlRent.Visible = false;
            pnlHome.Visible = true;
            pnlHome.Enabled = true;
            pnlRent.Enabled = false;
        }

        private void btnClear_Click(object sender, EventArgs e) //When the clear button is pushed, the code 
        {                                                       //will clear the values
            txtIncome.Clear();
            txtGroceries.Clear();
            txtWaterLights.Clear();
            txtTravel.Clear();
            txtPhone.Clear();
            txtExpenses.Clear();

            txtMonthRent.Clear();
            txtPurchasePrice.Clear();
            txtDeposit.Clear();
            txtInterestRate.Clear();
            txtNumOfMonths.Clear();

            txtMake.Clear();
            txtCarPrice.Clear();
            txtCardeposit.Clear();
            txtCarinterest.Clear();
            txtCarinsurance.Clear();
        }

        private void btnSubmit_Click(object sender, EventArgs e) //When the submit button is pushed, the code
        {                                                        //will output the values
            ErrorDelegate.FirstDelegate Error = new ErrorDelegate.FirstDelegate(errordelegate.Error);

            #region Income and expenses
            int Income = Convert.ToInt32(txtIncome.Text);
            int Groceries = Convert.ToInt32(txtGroceries.Text);
            int Utilities = Convert.ToInt32(txtWaterLights.Text);
            int TravelCost = Convert.ToInt32(txtTravel.Text);
            int CellPhone = Convert.ToInt32(txtPhone.Text);
            int OtherExpenses = Convert.ToInt32(txtExpenses.Text);
            #endregion

            #region Rent and housing
            int rent = Convert.ToInt32(txtMonthRent.Text);
            int house = Convert.ToInt32(txtPurchasePrice.Text);
            int deposit = Convert.ToInt32(txtDeposit.Text);
            int interest = Convert.ToInt32(txtInterestRate.Text);
            int numOfMonths = Convert.ToInt32(txtNumOfMonths.Text);
            #endregion

            #region Vehcile expenses
            string carType = Convert.ToString(txtMake.Text);
            int carPrice = Convert.ToInt32(txtCarPrice.Text);
            int carDeposit = Convert.ToInt32(txtCardeposit.Text);
            int carInterest = Convert.ToInt32(txtCarinterest.Text);
            int carInsurance = Convert.ToInt32(txtCarinsurance.Text);
            #endregion


            Accomodation ae = new Accomodation(Income, Groceries, Utilities, TravelCost, CellPhone,
                                            OtherExpenses, rent, house, deposit, interest, numOfMonths,
                                            carType, carPrice, carDeposit, carInterest, carInsurance);

            MessageBox.Show(ae.ToString());

            if (Groceries + Utilities + TravelCost + CellPhone + OtherExpenses + rent +
                house + deposit + carPrice + carDeposit + carInsurance >= (Income * 0.75))
            {
                Error();
            }

            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbIncomeTax_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbTitle_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
