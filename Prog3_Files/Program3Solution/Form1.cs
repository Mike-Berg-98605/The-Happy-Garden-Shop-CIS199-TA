using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program3Solution
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private const int MINQUANTITY = 0;
        private const int MINITEMNUM = 10001;
        private const int MAXITEMNUM = 10007;

        private readonly string[] gardenType = { "Premium", "Standard", "Discount" };
        private readonly double[] baseChargePrice = { 1.1, 1, 0.9 };

        private readonly int[] flowerIDs = { 10001, 10002, 10003, 10004, 10005, 10006, 10007 };
        private readonly double[] flowerCosts = { 7.87, 9.51, 10.73, 9.99, 11.99, 5.00, 4.58 };

        private readonly int[] quantitiesLowLimits = { 0, 6, 16, 21 };
        private readonly double[] percentOfFullPrice = { 1, 0.95, 0.9, 0.85 };

        private void calcButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("test");

            bool flowerFound = false;
            bool gardenFound = false;
            bool quantityFound = false;
            //since we only allow farm to come from a drop down box, do not need to validate other than that a value is selected
            if (gardenComboBox.SelectedIndex >=0)
            {
                //now check item number
                if (int.TryParse(itemTextBox.Text, out int flowerNum) && flowerNum >= MINITEMNUM && flowerNum <= MAXITEMNUM)
                {
                    //finish by checking quantity
                    if (int.TryParse(quantityTextBox.Text, out int quantity) && quantity >= MINQUANTITY)
                    {
                        //now we calculate our values
                        //first get product cost
                        double cost = 0; //default to zero
                        for (int i = 0; i < flowerIDs.Length && !flowerFound; ++i)
                        {
                            if (flowerIDs[i] == flowerNum)
                            {
                                flowerFound = true;
                                cost = flowerCosts[i];
                            }
                        }
                        //then we determine discount rate
                        double baseChargeRate = 0; //default to zero
                        for (int i = 0; i < gardenType.Length && !gardenFound; ++i)
                        {
                            if (gardenType[i] == gardenComboBox.Text)
                            {
                                gardenFound = true;
                                baseChargeRate = baseChargePrice[i];
                            }
                        }
                        //next get percentage off
                        double discounRate = 0; //default to zero
                        int index = quantitiesLowLimits.Length - 1;
                        while (index >= 0 && !quantityFound)
                        {
                            if (quantity >= quantitiesLowLimits[index])
                            {
                                quantityFound = true;
                            }
                            else
                            {
                                --index;
                            }
                        }
                        if (quantityFound)
                        {
                            discounRate = percentOfFullPrice[index];
                        }
                        //now calculate our costs
                        double flowersCost = cost * quantity;
                        flowerCostTextBox.Text = flowersCost.ToString("C");
                        double baseAdjustedCost = flowersCost * baseChargeRate;
                        baseAdjustedTextBox.Text = baseAdjustedCost.ToString("C");
                        double discountPercent = 1 - discounRate;
                        discountRateTextBox.Text =  discountPercent.ToString("P2");                     
                        double totalCost = baseAdjustedCost * discounRate;
                        totalPriceTextBox.Text = totalCost.ToString("C");
                    }
                    else
                    {
                        MessageBox.Show("Invalid Quantity/Entrees");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Entree Number");
                }
            }
            else
            {
                MessageBox.Show("No Garden Selected");
            }

        }
    }
}
