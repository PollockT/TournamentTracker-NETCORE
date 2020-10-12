using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TrackerLibrary;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        public CreatePrizeForm()
        {
            InitializeComponent();
        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PrizeModel model = new PrizeModel(
                    placeNameValue.Text, 
                    placeNumberValue.Text,
                    prizeAmountValue.Text, 
                    prizePercentageValue.Text);

                foreach(IDataConnection db in GlobalConfig.Connections)
                {
                    db.CreatePrize(model);
                }
                placeNameValue.Text = "";
                placeNumberValue.Text = "";
                prizeAmountValue.Text = "0";
                prizePercentageValue.Text = "0";


            }
            else
            {
                MessageBox.Show("This form has invalid information." +
                    " Please check the values entered!");
            }
        }

        private bool ValidateForm()
        {
            bool output = true;
            int placeNumber = 0;
            bool placeNumberValidNumber = int.TryParse(placeNumberValue.Text, out placeNumber);
           
            decimal prizeAmount = 0;
            bool prizeAmountValid = decimal.TryParse(prizeAmountValue.Text, out prizeAmount);
            
            double prizePercentage = 0;
            bool prizePercentageValid = double.TryParse(prizePercentageValue.Text, out prizePercentage);

            if (placeNumberValidNumber == false)
            {
                //TODO- Not Valid textbot alert
                output = false;
            }
            
            if(placeNumber < 1)
            {
                //TODO- Not Valid textbox alert
                output = false;
            }

            if(placeNameValue.Text.Length == 0)
            {
                //TODO- Not Valid textbox alert
                output = false;
            }
            
            if(prizeAmountValid == false || prizePercentageValid == false)
            {
                //TODO- Not Valid textbox alert
                output = false;
            }
            
            if(prizeAmount <= 0 && prizePercentage <= 0)
            {
                //TODO- Not Valid textbox alert
                output = false;
            }

            if(prizePercentage < 0 || prizePercentage < 100)
            {
                //TODO- Not Valid textbox alert
                output = false;
            }
            

            return output;
        }
    }
}
