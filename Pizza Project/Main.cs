using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Project
{
    public partial class Form1 : Form
    { 

        private void UpdateOrderSummary()
        {
            // The default values
            // we update to make the labels & price filled with correct info as soon as the form is loaded
            // The price is updated internaly in thoose functions.
            UpdateSize();
            UpdateToppings();
            UpdateCrust();
            UpdateWhereToEat();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateOrderSummary();
        }
        private void ResetForm()
        {
            ChangeGroupBoxes(true);
            UncheckToppingsCheckBoxes();

            rdMedium.Checked = true;
            rdThinCrust.Checked = true;
            rdTakeIn.Checked = true;
            btnOrderPizza.Enabled = true;
        }
        public Form1()
        {
            InitializeComponent();
        }
        void ChangeGroupBoxes(bool EnabledValue)
        {
            gbSize.Enabled = EnabledValue;
            gbCrustType.Enabled = EnabledValue;
            gbToppings.Enabled = EnabledValue;
            gbWhereToEat.Enabled = EnabledValue; 
        }
        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Order", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Order Placed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ChangeGroupBoxes(false);
            }
        }      
        private void btnResetForm_Click(object sender, EventArgs e)
        {
            ResetForm();
        } 
        private float GetSelectedSizePrice()
        {
            if (rdSmall.Checked)
            {
                return Convert.ToSingle(rdSmall.Tag);
            }
            else if (rdMedium.Checked)
            {
                return Convert.ToSingle(rdMedium.Tag);
            }
            else
            {
                return Convert.ToSingle(rdLarge.Tag);
            }
        }
        private float GetSelectedCrustPrice()
        {
            if(rdThickCrust.Checked)
            {
                return Convert.ToSingle(rdThickCrust.Tag);
            }
            else
            {
                return Convert.ToSingle(rdThinCrust.Tag);
            }
        } 
        private float CalculateToppingsPrice()
        {
            float TotalPrice = 0;

            if(chboxExtraCheese.Checked)
            {
                TotalPrice += Convert.ToSingle(chboxExtraCheese.Tag);
            }

            if (chOnion.Checked)
            {
                TotalPrice += Convert.ToSingle(chOnion.Tag);
            }
            if(cbMushrooms.Checked)
            {
                TotalPrice += Convert.ToSingle(cbMushrooms.Tag);
            }
            if(chOlives.Checked)
            {
                TotalPrice += Convert.ToSingle(chOlives.Tag);
            }
            if (chTomatoes.Checked)
            {
                TotalPrice += Convert.ToSingle(chTomatoes.Tag);
            }
            if(chGreenPeppers.Checked)
            {
                TotalPrice += Convert.ToSingle(chGreenPeppers.Tag);
            }

            return TotalPrice;
        }      
        private float GetSelectedWhereToEatPrice()
        {
            // both is 10 so it does not matter..
            return Convert.ToSingle(rdTakeOut.Tag);
        }
        private float CalculateTotalPrice()
        {
            // This function returns the tags for each group box..
            return GetSelectedSizePrice() + GetSelectedCrustPrice() + CalculateToppingsPrice() + GetSelectedWhereToEatPrice();
        }    
        private void UpdateTotalPrice()
        {
            TotalPriceLabel.Text = CalculateTotalPrice().ToString() + "$";
        }      
        private void UpdateSize()
        {
            UpdateTotalPrice();

            if (rdSmall.Checked)
            {
                SizeLabel.Text = "Small";
                return;
            }
            else if (rdMedium.Checked)
            {
                SizeLabel.Text = "Medium";
                return;
            }
            else
            {

                SizeLabel.Text = "Large";
                return;
            }
        }      
        private void UpdateCrust()
        {
            UpdateTotalPrice();
            if (rdThickCrust.Checked)
            {
                CrustLabel.Text = "Thick";
                return;
            }
            if (rdThinCrust.Checked)
            {
                CrustLabel.Text = "Thin";
                return;
            }
        }            
        private void UpdateWhereToEat()
        {
            UpdateTotalPrice();

            if(rdTakeIn.Checked)
            {
                LabelWhereToEat.Text = "Eat In";
            }
            else
            {
                LabelWhereToEat.Text = "Take Out";
            }
        }
        private void UpdateToppings()
        {
            UpdateTotalPrice();
            string sToppings = "";

            if(chboxExtraCheese.Checked)
            {
                sToppings = "Extra Cheese"; 
            }
            if (chOnion.Checked)
            {
                sToppings += ", Onion";
            }
            if (cbMushrooms.Checked)
            {
                sToppings += ", Mushrooms";
            }
            if(chOlives.Checked)
            {
                sToppings += ", Olives";
            }
            if(chTomatoes.Checked)
            {
                sToppings += ", Tomatoes";
            }
            if(chGreenPeppers.Checked)
            {
                sToppings += ", Green Peppers";
            }

            if(sToppings.StartsWith(","))
            {
                sToppings = sToppings.Substring(1,sToppings.Length - 1).Trim();
            }
            if(sToppings == "")
            {
                sToppings = "No Toppings";
            }

           ToppingsLabel.Text = sToppings; 
        }   
        private void rdSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize(); 
        }
        private void rdMedium_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }
        private void rdLarge_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }
        private void rdThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }
        private void rdThickCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }
        private void rdTakeIn_CheckedChanged(object sender, EventArgs e)
        {

            UpdateWhereToEat();
        }
        private void rdTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();

        }
        private void chboxExtraCheese_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }
        private void chOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();

        }   
        private void cbMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }
        private void chTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }
        private void chGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }
        private void chOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }
        void UncheckToppingsCheckBoxes()
        {
            cbMushrooms.Checked = false;
            chTomatoes.Checked = false;
            chGreenPeppers.Checked = false;
            chOlives.Checked = false;
            chOnion.Checked = false;
            chGreenPeppers.Checked = false;
            chboxExtraCheese.Checked = false;
        }
    }
}
