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
    public partial class EmployeeDetails : Form
    {
        public EmployeeDetails()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=I:\C# Project\CoffeeShop\CoffeeShop\CoffeeShop.mdf;Integrated Security=True");
        private void EmployeeDetails_Load(object sender, EventArgs e)
        {
            GetEmployeeRecord();
        }

        private void GetEmployeeRecord()
        {
            
            SqlCommand cmd = new SqlCommand("Select * from Employee", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader Sdr = cmd.ExecuteReader();
            dt.Load(Sdr);
            con.Close();

            EmployeedataGridView.DataSource = dt;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonInsert_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Employee VALUES (@Id, @name, @Gender, @dob, @address, @PhoneNo, @password)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", textId.Text);
                cmd.Parameters.AddWithValue("@name", textName.Text);
                cmd.Parameters.AddWithValue("@Gender", comboGender.Text);
                cmd.Parameters.AddWithValue("@dob", dateTimeDob.Text);
                cmd.Parameters.AddWithValue("@address", textAddres.Text);
                cmd.Parameters.AddWithValue("@PhoneNo", textPhn.Text);
                cmd.Parameters.AddWithValue("@password", textPass.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("New Employee are Successfully saved in the Database","Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetEmployeeRecord();
                ResetFormControls();
            }
        }

        private bool isValid()
        {
            if(textName.Text == string.Empty)
            {
                MessageBox.Show("Name is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            OwnerHome f1 = new OwnerHome();
            f1.Show();
            this.Hide();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            ResetFormControls();
        }

        private void ResetFormControls()
        {
            textId.Clear();
            textName.Clear();
            comboGender.Text = "";
            textAddres.Clear();
            textPhn.Clear();
            textPass.Clear();

            textId.Focus();
        }

        private void EmployeedataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textId.Text = EmployeedataGridView.SelectedRows[0].Cells[0].Value.ToString();
            textName.Text = EmployeedataGridView.SelectedRows[0].Cells[1].Value.ToString();
            comboGender.Text = EmployeedataGridView.SelectedRows[0].Cells[2].Value.ToString();
            dateTimeDob.Text = EmployeedataGridView.SelectedRows[0].Cells[3].Value.ToString();
            textAddres.Text = EmployeedataGridView.SelectedRows[0].Cells[4].Value.ToString();
            textPhn.Text = EmployeedataGridView.SelectedRows[0].Cells[5].Value.ToString();
            textPass.Text = EmployeedataGridView.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void buttonUpate_Click(object sender, EventArgs e)
        {
            if(textId.Text != "")
            {
                SqlCommand cmd = new SqlCommand("UPDATE Employee SET Id=@id, name= @name, Gender=@Gender, dob=@dob, address=@address, PhoneNo=@PhoneNo, password=@password WHERE Id =@Id", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", textId.Text);
                cmd.Parameters.AddWithValue("@name", textName.Text);
                cmd.Parameters.AddWithValue("@Gender", comboGender.Text);
                cmd.Parameters.AddWithValue("@dob", dateTimeDob.Text);
                cmd.Parameters.AddWithValue("@address", textAddres.Text);
                cmd.Parameters.AddWithValue("@PhoneNo", textPhn.Text);
                cmd.Parameters.AddWithValue("@password", textPass.Text);
                

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Employee Information is Updated Successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetEmployeeRecord();
                ResetFormControls();
            }
            else
            {
                MessageBox.Show("Please Select a Employee to Update his information", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textId.Text != "")
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Employee WHERE Id =@Id", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", textId.Text);
                

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Employee is Deleted from the system", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetEmployeeRecord();
                ResetFormControls();
            }
            else
            {
                MessageBox.Show("Please Select a Employee to Delete his information", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
