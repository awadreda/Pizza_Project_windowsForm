using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizzaProjectME
{
    public partial class v : Form
    {
        public v()
        {
            InitializeComponent();
        }

    float GetSizePrice()
        {
            if (rbSmall.Checked)
                return Convert.ToSingle(rbSmall.Tag);
            else if (rbMeduim.Checked)
                return Convert.ToSingle(rbMeduim.Tag);
            else
                return Convert.ToSingle(rbLarge.Tag);
        }

    float GetToppingsPrice()
        {
            float TotalToppings = 0;

            if (chkExtraChees.Checked)
                TotalToppings += Convert.ToSingle(chkExtraChees.Tag);

            if (chkTomatoes.Checked)
                TotalToppings += Convert.ToSingle(chkTomatoes.Tag);

            if (chkOlives.Checked)
                TotalToppings += Convert.ToSingle(chkOlives.Tag);

            if (chkOnion.Checked)
                TotalToppings += Convert.ToSingle(chkOnion.Tag);

            if (chkMushrooms.Checked)
                TotalToppings += Convert.ToSingle(chkMushrooms.Tag);

            if (chkGreenPeppers.Checked)
                TotalToppings += Convert.ToSingle(chkGreenPeppers.Tag);

            return TotalToppings;
        }


    float GetCrustPrice()
        {
            if (rpThin.Checked)
                return Convert.ToSingle(rpThin.Tag);
            else
                return Convert.ToSingle(rbThick.Tag);
        }


    float GetTotalPrice()
        {
            return GetSizePrice() + GetToppingsPrice() + GetCrustPrice();
        }

    void UpdateTotalPrice()
        {
            lbPrice.Text = "$"+ GetTotalPrice().ToString();
        }

    void UpdateSize()
        {
            UpdateTotalPrice();
            if (rbSmall.Checked)
            { lbSizeChoose.Text = "Small";
                return;
            }
            if(rbMeduim.Checked)
            {
                lbSizeChoose.Text = "Meduim";
                return;
            }

            if(rbLarge.Checked)
            {
                lbSizeChoose.Text = "Large";
                return;
            }
        }


    void UpdateToppings()
        {
            UpdateTotalPrice();
            string Toppings = "";

            if(chkExtraChees.Checked)
            {
                Toppings += "Extra Cheese ";
            }

            if(chkGreenPeppers.Checked)
            {
                Toppings += ",GreenPeppers ";
            }

            if(chkMushrooms.Checked)
            {
                Toppings += ",Mushrooms ";
            }

            if(chkOlives.Checked)
            {
                Toppings += ",Olives";
            }

            if(chkOnion.Checked)
            {
                Toppings += ",Onion ";
            }
            if(chkTomatoes.Checked)
            {
                Toppings += ",Tomatoes";
            }

            if(Toppings.StartsWith(","))
            {
                Toppings = Toppings.Substring(1, Toppings.Length - 1).Trim();
            }

            if (Toppings == "")
                Toppings = "No Toppings ";

            lbToppingsChoose.Text = Toppings;

        }

       
    void UpdateCrust()
        {
            UpdateTotalPrice();

            if(rpThin.Checked)
            {
                lbCrustChoosen.Text = " Thin ";

            }
            else
            {
                lbCrustChoosen.Text = " Thick ";
            }


        }

        void UpdateWhereToEat()
        {
            if(rpEatin.Checked)
            {
                lbWhereToEatChoose.Text = "Eat in ";
            }
            else
            {
                lbWhereToEatChoose.Text = "Take Out";
            }
        }

      void  UpdateOrderSummary()
        {
            UpdateTotalPrice();
            UpdateWhereToEat();
            UpdateCrust();
            UpdateSize();
            UpdateToppings();
               

        }

        void Reset()
        {
            //ResetGroupt
            gpCrust.Enabled =       true;
            gpSize.Enabled =        true;
            gpToppings.Enabled =    true;
            gbWhereToEat.Enabled =  true;

            //reset Size
            rbMeduim.Checked = true;

            //reset Toppings.
            chkExtraChees.Checked = false;
            chkOnion.Checked = false;
            chkMushrooms.Checked = false;
            chkOlives.Checked = false;
            chkTomatoes.Checked = false;
            chkGreenPeppers.Checked = false;

            //reset CrustType
            rpThin.Checked = true;

            //reset Where to Eat
            rpEatin.Checked = true;

            //Reset Order Button
            btOrderPizza.Enabled = true;


        }

        private void btOrderPizza_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Order ", "Confirm",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information)==DialogResult.OK)
            
            {
                btOrderPizza.Enabled = false;
                gpCrust.Enabled = false;
                gpSize.Enabled = false;
                gpToppings.Enabled = false;
                gbWhereToEat.Enabled = false;

            }
            else
            {
                MessageBox.Show("Update Your Order ", "Udate",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbMeduim_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();

        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rpThin_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void rbThick_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void chkExtraChees_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void rpEatin_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void rpTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void btResetForm_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void v_Load(object sender, EventArgs e)
        {
            UpdateOrderSummary();
        }

        private void lbToppingsChoose_Click(object sender, EventArgs e)
        {

        }
    }
}
