namespace CoffeeShop
{
    partial class OwnerHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonEmp = new System.Windows.Forms.Button();
            this.buttonBill = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonEmp
            // 
            this.buttonEmp.BackColor = System.Drawing.Color.Black;
            this.buttonEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmp.ForeColor = System.Drawing.Color.White;
            this.buttonEmp.Location = new System.Drawing.Point(216, 193);
            this.buttonEmp.Name = "buttonEmp";
            this.buttonEmp.Size = new System.Drawing.Size(131, 79);
            this.buttonEmp.TabIndex = 0;
            this.buttonEmp.Text = "Employee Details";
            this.buttonEmp.UseVisualStyleBackColor = false;
            this.buttonEmp.Click += new System.EventHandler(this.buttonEmp_Click);
            // 
            // buttonBill
            // 
            this.buttonBill.BackColor = System.Drawing.Color.Black;
            this.buttonBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBill.ForeColor = System.Drawing.Color.White;
            this.buttonBill.Location = new System.Drawing.Point(460, 193);
            this.buttonBill.Name = "buttonBill";
            this.buttonBill.Size = new System.Drawing.Size(124, 79);
            this.buttonBill.TabIndex = 1;
            this.buttonBill.Text = "Bill System";
            this.buttonBill.UseVisualStyleBackColor = false;
            this.buttonBill.Click += new System.EventHandler(this.buttonBill_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.Black;
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.ForeColor = System.Drawing.Color.White;
            this.buttonLogout.Location = new System.Drawing.Point(691, 447);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(99, 38);
            this.buttonLogout.TabIndex = 2;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // OwnerHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CoffeeShop.Properties.Resources.coffpl_nov_7;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(802, 497);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonBill);
            this.Controls.Add(this.buttonEmp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OwnerHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OwnerHome";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonEmp;
        private System.Windows.Forms.Button buttonBill;
        private System.Windows.Forms.Button buttonLogout;
    }
}