namespace CoffeeShop
{
    partial class EmployeeDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeDetails));
            this.labelName = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.EmployeedataGridView = new System.Windows.Forms.DataGridView();
            this.ButtonInsert = new System.Windows.Forms.Button();
            this.buttonUpate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.labelId = new System.Windows.Forms.Label();
            this.textId = new System.Windows.Forms.TextBox();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textAddres = new System.Windows.Forms.TextBox();
            this.labelDob = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textPhn = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textPass = new System.Windows.Forms.TextBox();
            this.dateTimeDob = new System.Windows.Forms.DateTimePicker();
            this.comboGender = new System.Windows.Forms.ComboBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeedataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            resources.ApplyResources(this.labelName, "labelName");
            this.labelName.Name = "labelName";
            // 
            // textName
            // 
            resources.ApplyResources(this.textName, "textName");
            this.textName.Name = "textName";
            // 
            // EmployeedataGridView
            // 
            this.EmployeedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.EmployeedataGridView, "EmployeedataGridView");
            this.EmployeedataGridView.Name = "EmployeedataGridView";
            this.EmployeedataGridView.RowTemplate.Height = 24;
            this.EmployeedataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EmployeedataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeedataGridView_CellClick);
            // 
            // ButtonInsert
            // 
            resources.ApplyResources(this.ButtonInsert, "ButtonInsert");
            this.ButtonInsert.Name = "ButtonInsert";
            this.ButtonInsert.UseVisualStyleBackColor = true;
            this.ButtonInsert.Click += new System.EventHandler(this.ButtonInsert_Click);
            // 
            // buttonUpate
            // 
            resources.ApplyResources(this.buttonUpate, "buttonUpate");
            this.buttonUpate.Name = "buttonUpate";
            this.buttonUpate.UseVisualStyleBackColor = true;
            this.buttonUpate.Click += new System.EventHandler(this.buttonUpate_Click);
            // 
            // buttonDelete
            // 
            resources.ApplyResources(this.buttonDelete, "buttonDelete");
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonReset
            // 
            resources.ApplyResources(this.buttonReset, "buttonReset");
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // labelId
            // 
            resources.ApplyResources(this.labelId, "labelId");
            this.labelId.Name = "labelId";
            // 
            // textId
            // 
            resources.ApplyResources(this.textId, "textId");
            this.textId.Name = "textId";
            // 
            // labelGender
            // 
            resources.ApplyResources(this.labelGender, "labelGender");
            this.labelGender.Name = "labelGender";
            // 
            // labelAddress
            // 
            resources.ApplyResources(this.labelAddress, "labelAddress");
            this.labelAddress.Name = "labelAddress";
            // 
            // textAddres
            // 
            resources.ApplyResources(this.textAddres, "textAddres");
            this.textAddres.Name = "textAddres";
            // 
            // labelDob
            // 
            resources.ApplyResources(this.labelDob, "labelDob");
            this.labelDob.Name = "labelDob";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // textPhn
            // 
            resources.ApplyResources(this.textPhn, "textPhn");
            this.textPhn.Name = "textPhn";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // textPass
            // 
            resources.ApplyResources(this.textPass, "textPass");
            this.textPass.Name = "textPass";
            // 
            // dateTimeDob
            // 
            resources.ApplyResources(this.dateTimeDob, "dateTimeDob");
            this.dateTimeDob.Name = "dateTimeDob";
            this.dateTimeDob.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            // 
            // comboGender
            // 
            resources.ApplyResources(this.comboGender, "comboGender");
            this.comboGender.FormattingEnabled = true;
            this.comboGender.Items.AddRange(new object[] {
            resources.GetString("comboGender.Items"),
            resources.GetString("comboGender.Items1")});
            this.comboGender.Name = "comboGender";
            // 
            // buttonExit
            // 
            resources.ApplyResources(this.buttonExit, "buttonExit");
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonBack
            // 
            resources.ApplyResources(this.buttonBack, "buttonBack");
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // EmployeeDetails
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboGender);
            this.Controls.Add(this.dateTimeDob);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpate);
            this.Controls.Add(this.ButtonInsert);
            this.Controls.Add(this.EmployeedataGridView);
            this.Controls.Add(this.textPass);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textPhn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelDob);
            this.Controls.Add(this.textAddres);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.labelName);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeDetails";
            this.Load += new System.EventHandler(this.EmployeeDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeedataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.DataGridView EmployeedataGridView;
        private System.Windows.Forms.Button ButtonInsert;
        private System.Windows.Forms.Button buttonUpate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textAddres;
        private System.Windows.Forms.Label labelDob;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textPhn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textPass;
        private System.Windows.Forms.DateTimePicker dateTimeDob;
        private System.Windows.Forms.ComboBox comboGender;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBack;
    }
}