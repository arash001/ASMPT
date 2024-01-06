namespace ASMPTUIWinForm
{
    partial class frmBorrowU
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
            cmbStudent = new ComboBox();
            groupBox1 = new GroupBox();
            button1 = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            enddateTimePicker2 = new DateTimePicker();
            startdateTimePicker1 = new DateTimePicker();
            cmbbook = new ComboBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // cmbStudent
            // 
            cmbStudent.FormattingEnabled = true;
            cmbStudent.Location = new Point(72, 29);
            cmbStudent.Margin = new Padding(2);
            cmbStudent.Name = "cmbStudent";
            cmbStudent.Size = new Size(128, 23);
            cmbStudent.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(enddateTimePicker2);
            groupBox1.Controls.Add(startdateTimePicker1);
            groupBox1.Controls.Add(cmbbook);
            groupBox1.Controls.Add(cmbStudent);
            groupBox1.Location = new Point(11, 11);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(522, 221);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Create Borrow";
            // 
            // button1
            // 
            button1.Location = new Point(428, 178);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(79, 29);
            button1.TabIndex = 8;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 120);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(18, 15);
            label4.TabIndex = 7;
            label4.Text = "to";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 80);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 6;
            label3.Text = "from";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(289, 26);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 5;
            label2.Text = "Book";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 27);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 4;
            label1.Text = "Student";
            // 
            // enddateTimePicker2
            // 
            enddateTimePicker2.Location = new Point(54, 118);
            enddateTimePicker2.Margin = new Padding(2);
            enddateTimePicker2.Name = "enddateTimePicker2";
            enddateTimePicker2.Size = new Size(211, 23);
            enddateTimePicker2.TabIndex = 3;
            // 
            // startdateTimePicker1
            // 
            startdateTimePicker1.Location = new Point(54, 80);
            startdateTimePicker1.Margin = new Padding(2);
            startdateTimePicker1.Name = "startdateTimePicker1";
            startdateTimePicker1.Size = new Size(211, 23);
            startdateTimePicker1.TabIndex = 2;
            // 
            // cmbbook
            // 
            cmbbook.FormattingEnabled = true;
            cmbbook.Location = new Point(334, 26);
            cmbbook.Margin = new Padding(2);
            cmbbook.Name = "cmbbook";
            cmbbook.Size = new Size(128, 23);
            cmbbook.TabIndex = 1;
            // 
            // frmBorrowU
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 246);
            Controls.Add(groupBox1);
            Margin = new Padding(2);
            Name = "frmBorrowU";
            Text = "frmBorrowU";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbStudent;
        private GroupBox groupBox1;
        private DateTimePicker enddateTimePicker2;
        private DateTimePicker startdateTimePicker1;
        private ComboBox cmbbook;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
    }
}