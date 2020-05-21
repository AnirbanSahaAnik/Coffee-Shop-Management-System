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
    public partial class EmployeeLogin : Form
    {
        public EmployeeLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=I:\C# Project\CoffeeShop\CoffeeShop\CoffeeShop.mdf;Integrated Security=True");
            string query = "Select * from Employee WHERE Id= '"+textBoxUserId.Text.Trim()+ "' and password = '"+textBoxPass.Text.Trim()+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if(dtbl.Rows.Count==1)
            {
                bill f1 = new bill();
                this.Hide();
                f1.Show();
            }
            else
            {
                MessageBox.Show("Check your User Id or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Home f1 = new Home();
            f1.Show();
            this.Hide();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
