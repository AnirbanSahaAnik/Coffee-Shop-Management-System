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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void butOwner_Click(object sender, EventArgs e)
        {
            OwnerLogin mynewfrom = new OwnerLogin();

            mynewfrom.Show();
            this.Hide();
        }

        private void butEmp_Click(object sender, EventArgs e)
        {
            EmployeeLogin mynewfrom2 = new EmployeeLogin();

            mynewfrom2.Show();
            this.Hide();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
