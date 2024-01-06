namespace ASMPTUIWinForm
{
    partial class frmStudentU
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
            groupBox1 = new GroupBox();
            txtEmail = new TextBox();
            label4 = new Label();
            txtName = new TextBox();
            label1 = new Label();
            txtId = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtLastname = new TextBox();
            groupBox2 = new GroupBox();
            txtPostalCode = new TextBox();
            label5 = new Label();
            txtStreet = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txtHouseNumber = new TextBox();
            label8 = new Label();
            txtCity = new TextBox();
            btnSave = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtLastname);
            groupBox1.Location = new Point(28, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(723, 104);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Student";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(311, 62);
            txtEmail.Margin = new Padding(2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(106, 23);
            txtEmail.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(227, 62);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 13;
            label4.Text = "Email";
            // 
            // txtName
            // 
            txtName.Location = new Point(81, 54);
            txtName.Margin = new Padding(2);
            txtName.Name = "txtName";
            txtName.Size = new Size(106, 23);
            txtName.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 54);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 7;
            label1.Text = "Name";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtId
            // 
            txtId.Location = new Point(81, 22);
            txtId.Margin = new Padding(2);
            txtId.Name = "txtId";
            txtId.Size = new Size(106, 23);
            txtId.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(227, 30);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 8;
            label2.Text = "Surename";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 25);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(18, 15);
            label3.TabIndex = 11;
            label3.Text = "ID";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtLastname
            // 
            txtLastname.Location = new Point(311, 25);
            txtLastname.Margin = new Padding(2);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(106, 23);
            txtLastname.TabIndex = 10;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtCity);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtPostalCode);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtStreet);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtHouseNumber);
            groupBox2.Location = new Point(28, 123);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(723, 104);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Address";
            // 
            // txtPostalCode
            // 
            txtPostalCode.Location = new Point(81, 67);
            txtPostalCode.Margin = new Padding(2);
            txtPostalCode.Name = "txtPostalCode";
            txtPostalCode.Size = new Size(106, 23);
            txtPostalCode.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 72);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 13;
            label5.Text = "PostalCode";
            // 
            // txtStreet
            // 
            txtStreet.Location = new Point(81, 25);
            txtStreet.Margin = new Padding(2);
            txtStreet.Name = "txtStreet";
            txtStreet.Size = new Size(106, 23);
            txtStreet.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 25);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(37, 15);
            label6.TabIndex = 7;
            label6.Text = "Street";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(227, 30);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(85, 15);
            label7.TabIndex = 8;
            label7.Text = "HouseNumber";
            // 
            // txtHouseNumber
            // 
            txtHouseNumber.Location = new Point(316, 25);
            txtHouseNumber.Margin = new Padding(2);
            txtHouseNumber.Name = "txtHouseNumber";
            txtHouseNumber.Size = new Size(106, 23);
            txtHouseNumber.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(259, 70);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(28, 15);
            label8.TabIndex = 15;
            label8.Text = "City";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(316, 64);
            txtCity.Margin = new Padding(2);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(106, 23);
            txtCity.TabIndex = 16;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(676, 233);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 16;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // frmStudentU
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(757, 262);
            Controls.Add(btnSave);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmStudentU";
            Text = "frmStudentU";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtName;
        private Label label1;
        private TextBox txtId;
        private Label label2;
        private Label label3;
        private TextBox txtLastname;
        private TextBox txtEmail;
        private Label label4;
        private GroupBox groupBox2;
        private TextBox txtPostalCode;
        private Label label5;
        private TextBox txtStreet;
        private Label label6;
        private Label label7;
        private TextBox txtHouseNumber;
        private TextBox txtCity;
        private Label label8;
        private Button btnSave;
    }
}