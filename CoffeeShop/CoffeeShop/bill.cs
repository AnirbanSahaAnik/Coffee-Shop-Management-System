using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
    public partial class bill : Form
    {
        public bill()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonRest_Click(object sender, EventArgs e)
        {
            textLatte.Text = "0";
            textCappuchino.Text = "0";
            textEspresso.Text = "0";
            textMochaccino.Text = "0";
            textFilter.Text = "0";
            textIrish.Text = "0";
            textFlat.Text = "0";
            textAffogato.Text = "0";
            textBoxBbqBurger.Text = "0";
            textDelightBurger.Text = "0";
            textCrispyBurger.Text = "0";
            textClubSandwich.Text = "0";
            textCheeseSandwich.Text = "0";
            textChickenFry.Text = "0";
            textNachos.Text = "0";
            textFrenchFries.Text = "0";
            labelCostDrinks.Text = "0";
            labelCostOthers.Text = "0";
            labelService.Text = "0";
            labelSubTotal.Text = "0";
            labelTax.Text = "0";
            labelTotal.Text = "0";
           

            cheLatte.Checked = false;
            cheAffogato.Checked = false;
            cheCappuccino.Checked = false;
            cheFilter.Checked = false;
            cheFlat.Checked = false;
            cheIrish.Checked = false;
            cheEspresso.Checked = false;
            cheMochaccion.Checked = false;
            cheBbqBurger.Checked = false;
            cheChickenDelighitBurger.Checked = false;
            cheCrispyBurger.Checked = false;
            cheClubSandwich.Checked = false;
            cheCheeseSandwich.Checked = false;
            cheChickenFry.Checked = false;
            cheNachos.Checked = false;
            cheFrencFries.Checked = false;


        }

        private void labelCostOthers_Click(object sender, EventArgs e)
        {

        }

        private void bill_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongDateString();
            timer1.Start(); 

            textLatte.Text = "0";
            textCappuchino.Text = "0";
            textEspresso.Text = "0";
            textMochaccino.Text = "0";
            textFilter.Text = "0";
            textIrish.Text = "0";
            textFlat.Text = "0";
            textAffogato.Text = "0";
            textBoxBbqBurger.Text = "0";
            textDelightBurger.Text = "0";
            textCrispyBurger.Text = "0";
            textClubSandwich.Text = "0";
            textCheeseSandwich.Text = "0";
            textChickenFry.Text = "0";
            textNachos.Text = "0";
            textFrenchFries.Text = "0";
            labelCostDrinks.Text = "0";
            labelCostOthers.Text = "0";
            labelService.Text = "0";
            
            
            textLatte.Enabled = false;
            textCappuchino.Enabled = false;
            textEspresso.Enabled = false;
            textMochaccino.Enabled = false;
            textFilter.Enabled = false;
            textIrish.Enabled = false;
            textFlat.Enabled = false;
            textAffogato.Enabled = false;
            textBoxBbqBurger.Enabled = false;
            textDelightBurger.Enabled = false;
            textCrispyBurger.Enabled = false;
            textClubSandwich.Enabled = false;
            textCheeseSandwich.Enabled = false;
            textChickenFry.Enabled = false;
            textNachos.Enabled = false;
            textFrenchFries.Enabled = false;

            cheLatte.Checked = false;
            cheAffogato.Checked = false;
            cheCappuccino.Checked = false;
            cheFilter.Checked = false;
            cheFlat.Checked = false;
            cheIrish.Checked = false;
            cheEspresso.Checked = false;
            cheMochaccion.Checked = false;
            cheBbqBurger.Checked = false;
            cheChickenDelighitBurger.Checked = false;
            cheCrispyBurger.Checked = false;
            cheClubSandwich.Checked = false;
            cheCheeseSandwich.Checked = false;
            cheChickenFry.Checked = false;
            cheNachos.Checked = false;
            cheFrencFries.Checked = false;

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cheLatte_CheckedChanged(object sender, EventArgs e)
        {
            if(cheLatte.Checked == true)
            {
                textLatte.Enabled = true;
            }
            if(cheLatte.Checked == false)
            {
                textLatte.Enabled = false;
                textLatte.Text = "0";
            }
        }

        private void textLattle_Click(object sender, EventArgs e)
        {
            textLatte.Text = "";
            textLatte.Focus();
        }

        private void cheCappuccino_CheckedChanged(object sender, EventArgs e)
        {
            if (cheCappuccino.Checked == true)
            {
                textCappuchino.Enabled = true;
            }
            if (cheCappuccino.Checked == false)
            {
                textCappuchino.Enabled = false;
                textCappuchino.Text = "0";
            }
        }

        private void cheEspresso_CheckedChanged(object sender, EventArgs e)
        {
            if (cheEspresso.Checked == true)
            {
                textEspresso.Enabled = true;
            }
            if (cheEspresso.Checked == false)
            {
                textEspresso.Enabled = false;
                textEspresso.Text = "0";
            }
        }

        private void cheMochaccion_CheckedChanged(object sender, EventArgs e)
        {
            if (cheMochaccion.Checked == true)
            {
                textMochaccino.Enabled = true;
            }
            if (cheMochaccion.Checked == false)
            {
                textMochaccino.Enabled = false;
                textMochaccino.Text = "0";
            }
        }

        private void cheFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (cheFilter.Checked == true)
            {
                textFilter.Enabled = true;
            }
            if (cheFilter.Checked == false)
            {
                textFilter.Enabled = false;
                textFilter.Text = "0";
            }
        }

        private void cheIrish_CheckedChanged(object sender, EventArgs e)
        {
            if (cheIrish.Checked == true)
            {
                textIrish.Enabled = true;
            }
            if (cheIrish.Checked == false)
            {
                textIrish.Enabled = false;
                textIrish.Text = "0";
            }
        }

        private void cheFlat_CheckedChanged(object sender, EventArgs e)
        {
            if (cheFlat.Checked == true)
            {
                textFlat.Enabled = true;
            }
            if (cheFlat.Checked == false)
            {
                textFlat.Enabled = false;
                textFlat.Text = "0";
            }
        }

        private void cheAffogato_CheckedChanged(object sender, EventArgs e)
        {
            if (cheAffogato.Checked == true)
            {
                textAffogato.Enabled = true;
            }
            if (cheAffogato.Checked == false)
            {
                textAffogato.Enabled = false;
                textAffogato.Text = "0";
            }
        }

        private void cheBbqBurger_CheckedChanged(object sender, EventArgs e)
        {
            if (cheBbqBurger.Checked == true)
            {
                textBoxBbqBurger.Enabled = true;
            }
            if (cheBbqBurger.Checked == false)
            {
                textBoxBbqBurger.Enabled = false;
                textBoxBbqBurger.Text = "0";
            }
        }

        private void cheChickenDelighitBurger_CheckedChanged(object sender, EventArgs e)
        {
            if (cheChickenDelighitBurger.Checked == true)
            {
                textDelightBurger.Enabled = true;
            }
            if (cheChickenDelighitBurger.Checked == false)
            {
                textDelightBurger.Enabled = false;
                textDelightBurger.Text = "0";
            }
        }

        private void cheCrispyBurger_CheckedChanged(object sender, EventArgs e)
        {
            if (cheCrispyBurger.Checked == true)
            {
                textCrispyBurger.Enabled = true;
            }
            if (cheCrispyBurger.Checked == false)
            {
                textCrispyBurger.Enabled = false;
                textCrispyBurger.Text = "0";
            }
        }

        private void cheClubSandwich_CheckedChanged(object sender, EventArgs e)
        {
            if (cheClubSandwich.Checked == true)
            {
                textClubSandwich.Enabled = true;
            }
            if (cheClubSandwich.Checked == false)
            {
                textClubSandwich.Enabled = false;
                textClubSandwich.Text = "0";
            }
        }

        private void cheCheeseSandwich_CheckedChanged(object sender, EventArgs e)
        {
            if (cheCheeseSandwich.Checked == true)
            {
                textCheeseSandwich.Enabled = true;
            }
            if (cheCheeseSandwich.Checked == false)
            {
                textCheeseSandwich.Enabled = false;
                textCheeseSandwich.Text = "0";
            }
        }

        private void cheChickenFry_CheckedChanged(object sender, EventArgs e)
        {
            if (cheChickenFry.Checked == true)
            {
                textChickenFry.Enabled = true;
            }
            if (cheChickenFry.Checked == false)
            {
                textChickenFry.Enabled = false;
                textChickenFry.Text = "0";
            }
        }

        private void cheNachos_CheckedChanged(object sender, EventArgs e)
        {
            if (cheNachos.Checked == true)
            {
                textNachos.Enabled = true;
            }
            if (cheNachos.Checked == false)
            {
                textNachos.Enabled = false;
                textNachos.Text = "0";
            }
        }

        private void cheFrencFries_CheckedChanged(object sender, EventArgs e)
        {
            if (cheFrencFries.Checked == true)
            {
                textFrenchFries.Enabled = true;
            }
            if (cheFrencFries.Checked == false)
            {
                textFrenchFries.Enabled = false;
                textFrenchFries.Text = "0";
            }
        }

        private void textCappuchino_TextChanged(object sender, EventArgs e)
        {

        }

        private void textCappuchino_Click(object sender, EventArgs e)
        {
            textCappuchino.Text = "";
            textCappuchino.Focus();
        }

        private void textEspresso_Click(object sender, EventArgs e)
        {
            textEspresso.Text = "";
            textEspresso.Focus();
        }

        private void textMochaccino_Click(object sender, EventArgs e)
        {
            textMochaccino.Text = "";
            textMochaccino.Focus();
        }

        private void textFilter_Click(object sender, EventArgs e)
        {
            textFilter.Text = "";
            textFilter.Focus();
        }

        private void textIrish_Click(object sender, EventArgs e)
        {
            textIrish.Text = "";
            textIrish.Focus();
        }

        private void textFlat_Click(object sender, EventArgs e)
        {
            textFlat.Text = "";
            textFlat.Focus();
        }

        private void textAffogato_Click(object sender, EventArgs e)
        {
            textAffogato.Text = "";
            textAffogato.Focus();
        }

        private void textBoxBbqBurger_Click(object sender, EventArgs e)
        {
            textBoxBbqBurger.Text = "";
            textBoxBbqBurger.Focus();
        }

        private void textDelightBurger_Click(object sender, EventArgs e)
        {
            textDelightBurger.Text = "";
            textDelightBurger.Focus();
        }

        private void textCrispyBurger_Click(object sender, EventArgs e)
        {
            textCrispyBurger.Text = "";
            textCrispyBurger.Focus();
        }

        private void textClubSandwich_Click(object sender, EventArgs e)
        {
            textClubSandwich.Text = "";
            textClubSandwich.Focus();
        }

        private void textCheeseSandwich_Click(object sender, EventArgs e)
        {
            textCheeseSandwich.Text = "";
            textCheeseSandwich.Focus();
        }

        private void textChickenFry_Click(object sender, EventArgs e)
        {
            textChickenFry.Text = "";
            textChickenFry.Focus();
        }

        private void textNachos_Click(object sender, EventArgs e)
        {
            textNachos.Text = "";
            textNachos.Focus();
        }

        private void textFrenchFries_Click(object sender, EventArgs e)
        {
            textFrenchFries.Text = "";
            textFrenchFries.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString(); 
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(rtfReceipt.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 120, 120);
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            rtfReceipt.Clear();
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            rtfReceipt.Cut();
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            rtfReceipt.Copy();
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            rtfReceipt.Paste();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //rtfReceipt.Loadfile(openFile.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.FileName = "Notepad Text";
            saveFile.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";
            if(saveFile.ShowDialog() == DialogResult.OK)
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(saveFile.FileName))
                    sw.WriteLine(rtfReceipt.Text);
            }
        }

        private void buttonReceipt_Click(object sender, EventArgs e)
        {
            rtfReceipt.Clear();

            rtfReceipt.AppendText(Environment.NewLine);
            rtfReceipt.AppendText("-------------------------------------------------------" + Environment.NewLine);
            rtfReceipt.AppendText("\t" + "Coffee Express" + Environment.NewLine);
            rtfReceipt.AppendText("-------------------------------------------------------" + Environment.NewLine);
            rtfReceipt.AppendText("Latte \t\t\t" + textLatte.Text + Environment.NewLine);
            rtfReceipt.AppendText("Cappuccino \t\t" + textCappuchino.Text + Environment.NewLine);
            rtfReceipt.AppendText("Espresso \t\t\t" + textEspresso.Text + Environment.NewLine);
            rtfReceipt.AppendText("Mochaccino \t\t" + textMochaccino.Text + Environment.NewLine);
            rtfReceipt.AppendText("Filter Coffee \t\t" + textFilter.Text + Environment.NewLine);
            rtfReceipt.AppendText("Irish Coffee \t\t" + textIrish.Text + Environment.NewLine);
            rtfReceipt.AppendText("Flat Coffee \t\t" + textFlat.Text + Environment.NewLine);
            rtfReceipt.AppendText("Affogato \t\t\t" + textAffogato.Text + Environment.NewLine);
            rtfReceipt.AppendText("BBQ Chicken Burger \t" + textBoxBbqBurger.Text + Environment.NewLine);
            rtfReceipt.AppendText("Chicken Delight Burger \t" + textDelightBurger.Text + Environment.NewLine);
            rtfReceipt.AppendText("Crispy Burger \t\t" + textCrispyBurger.Text + Environment.NewLine);
            rtfReceipt.AppendText("Club Sandwich \t\t" + textClubSandwich.Text + Environment.NewLine);
            rtfReceipt.AppendText("Cheese Sandwich \t\t" + textCheeseSandwich.Text + Environment.NewLine);
            rtfReceipt.AppendText("Chicken Fry \t\t" + textChickenFry.Text + Environment.NewLine);
            rtfReceipt.AppendText("Nachos \t\t\t" + textNachos.Text + Environment.NewLine);
            rtfReceipt.AppendText("French Fries \t\t" + textFrenchFries.Text + Environment.NewLine);
            rtfReceipt.AppendText("--------------------------------------------------------" + Environment.NewLine);
            rtfReceipt.AppendText("Sercice Charge \t\t" + labelService.Text + Environment.NewLine);
            rtfReceipt.AppendText("--------------------------------------------------------" + Environment.NewLine);
            rtfReceipt.AppendText("Tax \t\t\t" + labelTax.Text + Environment.NewLine);
            rtfReceipt.AppendText("Sub Total \t\t" + labelSubTotal.Text + Environment.NewLine);
            rtfReceipt.AppendText("Total \t\t\t" + labelTotal.Text + Environment.NewLine);
            rtfReceipt.AppendText("--------------------------------------------------------" + Environment.NewLine);
            rtfReceipt.AppendText(lblTime.Text + "\t\t" + lblDate.Text);
        }

        private void buttonTotal_Click(object sender, EventArgs e)
        {
            double tax;
            tax = 0.45;
            double latte, cappu, espr, mochac, filterCoff, irishCoff, flatCoff, affogato;
            double bbqBurg, delightBurg, crispyBurg, clubSan, cheeseSan, chiFry, nachos, freFries;
            
            //coffee
            latte = 60; cappu = 70; espr = 90; mochac = 120; filterCoff = 80; irishCoff = 70; flatCoff = 70; affogato = 90;

            double latte_c = Convert.ToDouble(textLatte.Text);
            double cappu_c = Convert.ToDouble(textCappuchino.Text);
            double espr_c = Convert.ToDouble(textEspresso.Text);
            double mochac_c = Convert.ToDouble(textMochaccino.Text);
            double filterCoff_c = Convert.ToDouble(textFilter.Text);
            double irishCoff_c = Convert.ToDouble(textIrish.Text);
            double flatCoff_c = Convert.ToDouble(textFlat.Text);
            double affogato_c = Convert.ToDouble(textAffogato.Text);

            //others
            bbqBurg = 80; delightBurg = 70; crispyBurg = 70; clubSan = 60; cheeseSan = 70; chiFry = 65; nachos = 80; freFries = 40;

            double bbqBurg_o = Convert.ToDouble(textBoxBbqBurger.Text) ;
            double delightBurg_o = Convert.ToDouble(textDelightBurger.Text) ;
            double crispyBurg_o = Convert.ToDouble(textCrispyBurger.Text) ;
            double clubSan_o = Convert.ToDouble(textClubSandwich.Text) ;
            double cheeseSan_o = Convert.ToDouble(textCheeseSandwich.Text) ;
            double chiFry_o = Convert.ToDouble(textChickenFry.Text) ;
            double nachos_o = Convert.ToDouble(textNachos.Text) ;
            double freFries_o = Convert.ToDouble(textFrenchFries.Text) ;

            Coffee eat_in_cafe = new Coffee(latte_c, cappu_c, espr_c, mochac_c, filterCoff_c,
                irishCoff_c, flatCoff_c, affogato_c, bbqBurg_o, delightBurg_o, crispyBurg_o, clubSan_o,
                cheeseSan_o, chiFry_o, nachos_o, freFries_o);

            double cost_of_drinks = (latte_c * latte) + (cappu_c * cappu) + (espr_c * espr) + (mochac_c * mochac)
                + (filterCoff_c * filterCoff) + (irishCoff_c * irishCoff) + (flatCoff_c * flatCoff) + (affogato_c * affogato);
            labelCostDrinks.Text = Convert.ToString(cost_of_drinks);

            double cost_of_others = (bbqBurg_o * bbqBurg) + (delightBurg_o * delightBurg) + (crispyBurg_o * crispyBurg)
                + (clubSan_o * clubSan) + (cheeseSan_o * cheeseSan) + (chiFry_o * chiFry) + (nachos_o * nachos) 
                + (freFries_o * freFries);
            labelCostOthers.Text = Convert.ToString(cost_of_others);

            
            labelService.Text = Convert.ToString(((cost_of_drinks + cost_of_others) * 3) / 100);
            double Service_charge = Convert.ToDouble(labelService.Text);
            labelSubTotal.Text = Convert.ToString(cost_of_drinks + cost_of_others + Service_charge);
            labelTax.Text = Convert.ToString(((cost_of_drinks + cost_of_others + Service_charge) * tax) / 100);
            double iTax = Convert.ToDouble(labelTax.Text);
            labelTotal.Text = Convert.ToString(cost_of_drinks + cost_of_others + iTax + Service_charge);
            

            labelCostDrinks.Text = String.Format("{0:C}", cost_of_drinks);
            labelCostOthers.Text = String.Format("{0:C}", cost_of_others);
            labelService.Text = String.Format("{0:C}", Service_charge);
            labelSubTotal.Text = String.Format("{0:C}", (cost_of_drinks + cost_of_others + Service_charge));
            labelTax.Text = String.Format("{0:C}", iTax);
            labelTotal.Text = String.Format("{0:C}", (cost_of_drinks + cost_of_others + Service_charge + iTax));
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Home f1 = new Home();
            this.Hide();
            f1.Show();
        }

        private void rtfReceipt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
