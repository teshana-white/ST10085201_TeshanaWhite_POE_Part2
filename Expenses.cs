using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POEpart2;

namespace POEpart2
{
    public abstract class Expenses
    {
        #region income and expenses 
        //declaring the income and expenses variables
        public int income;
        public int groceries;
        public int utilities;
        public int travelCost;
        public int cellPhone;
        public int otherExpenses;
        public double total;
        public double deductions;
        #endregion

        #region Income and expenses gets and sets
        //the getters and setters storing the inputted income and expenses
        public int Income { get => income; set => income = value; }
        public int Groceries { get => groceries; set => groceries = value; }
        public int Utilities { get => utilities; set => utilities = value; }
        public int TravelCost { get => travelCost; set => travelCost = value; }
        public int CellPhone { get => cellPhone; set => cellPhone = value; }
        public int OtherExpenses { get => otherExpenses; set => otherExpenses = value; }
        public double Total;
        public double Deductions;
        #endregion

        #region vehcile expenses
        //declaring the variables for the vehicle expenses
        public string carType;
        public int carPrice;
        public int carDeposit;
        public int carInterest;
        public int carInsurance;
        public double carTotal;
        #endregion

        #region Vehcile expenses gets and sets
        //the getters and setters storing all the 
        public string CarType { get => carType; set => carType = value; }
        public int CarPrice { get => carPrice; set => carPrice = value; }
        public int CarDeposit { get => carDeposit; set => carDeposit = value; }
        public int CarInterest { get => carInterest; set => carInterest = value; }
        public int CarInsurance { get => carInsurance; set => carInsurance = value; }
        public double CarTotal { get => carTotal; set => carTotal = value; }
        #endregion


        public Expenses(int income, int groceries, int utilities, int travelCost, int cellPhone,
                             int otherExpenses, string carType, int carPrice, int carDeposit, int carInterest, 
                             int carInsurance)

        {
            #region income and expenses
            this.Income = income;
            this.Groceries = groceries;
            this.Utilities = utilities;
            this.TravelCost = travelCost;
            this.CellPhone = cellPhone;
            this.OtherExpenses = otherExpenses;

            #region Vehicle
            this.carType = carType;
            this.carPrice = carPrice;
            this.carDeposit = carDeposit;
            this.carInterest = carInterest;
            this.carInsurance = carInsurance;
            this.carTotal = CalculateCarTotal(carPrice, carInsurance, carInterest, carDeposit);
            #endregion

            this.total = CalculateTotal(groceries, utilities, travelCost, cellPhone, otherExpenses, deductions);
            this.deductions = TaxDeductions(income);
            #endregion


        }

        public double CalculateCarTotal(int carPrice, int carInsurance, int carInterest, int carDeposit) //calculates car monthly payment
        {
            return (((this.carPrice - this.CarDeposit) * (1 + (this.carInterest / 100) * 60) / 60) + this.carInsurance);
        }

        public double TaxDeductions(int income) //calculates tax deductions
        {
            return (0.15 * income);
        }

        public double CalculateTotal( int groceries, int utilities, int travelCost, 
                                      int cellPhone, int otherExpenses, double deductions) //calculates total expenses
        {
            return deductions + groceries + utilities + travelCost + cellPhone + otherExpenses;
        }

    }
}
