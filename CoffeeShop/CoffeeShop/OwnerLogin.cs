using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CoffeeShop
{
    public partial class OwnerLogin : Form
    {
        public OwnerLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=I:\C# Project\CoffeeShop\CoffeeShop\CoffeeShop.mdf;Integrated Security=True");
            string query = "Select * from Admin WHERE Id= '" + textBoxUserId.Text.Trim() + "' and Password = '" + textBoxPass.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                OwnerHome f1 = new OwnerHome();
                f1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Check your User Id or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void textBoxPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Home f2 = new Home();
            f2.Show();
            this.Hide();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
