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
    public partial class OwnerHome : Form
    {
        public OwnerHome()
        {
            InitializeComponent();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            OwnerLogin f1 = new OwnerLogin();
            f1.Show();
            this.Hide();
        }

        private void buttonBill_Click(object sender, EventArgs e)
        {
            bill f2 = new bill();
            f2.Show();
            this.Hide();
        }

        private void buttonEmp_Click(object sender, EventArgs e)
        {
            EmployeeDetails f3 = new EmployeeDetails();
            f3.Show();
            this.Hide();
        }
    }
}
