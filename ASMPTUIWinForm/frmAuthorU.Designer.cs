namespace ASMPTUIWinForm
{
    partial class frmAuthorU
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
            btnSave = new Button();
            label1 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            txtLastname = new TextBox();
            label3 = new Label();
            txtId = new TextBox();
            label4 = new Label();
            groupBox1 = new GroupBox();
            btnDelete = new Button();
            btnAdd = new Button();
            txtBookId = new TextBox();
            label6 = new Label();
            txtIsbn = new TextBox();
            label5 = new Label();
            txtTitel = new TextBox();
            groupBox2 = new GroupBox();
            dgvBook = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBook).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(439, 69);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(78, 25);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 55);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 1;
            label1.Text = "Name";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(236, 31);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 2;
            label2.Text = "Nachname";
            // 
            // txtName
            // 
            txtName.Location = new Point(90, 55);
            txtName.Margin = new Padding(2);
            txtName.Name = "txtName";
            txtName.Size = new Size(106, 23);
            txtName.TabIndex = 3;
            // 
            // txtLastname
            // 
            txtLastname.Location = new Point(320, 26);
            txtLastname.Margin = new Padding(2);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(106, 23);
            txtLastname.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 26);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(18, 15);
            label3.TabIndex = 5;
            label3.Text = "ID";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtId
            // 
            txtId.Location = new Point(90, 23);
            txtId.Margin = new Padding(2);
            txtId.Name = "txtId";
            txtId.Size = new Size(106, 23);
            txtId.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 50);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 7;
            label4.Text = "Title";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(txtBookId);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtIsbn);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtTitel);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(8, 96);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(531, 107);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "book";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(236, 47);
            btnDelete.Margin = new Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(78, 25);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(236, 20);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(78, 25);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtBookId
            // 
            txtBookId.Location = new Point(88, 20);
            txtBookId.Margin = new Padding(2);
            txtBookId.Name = "txtBookId";
            txtBookId.Size = new Size(106, 23);
            txtBookId.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(50, 18);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(18, 15);
            label6.TabIndex = 7;
            label6.Text = "ID";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtIsbn
            // 
            txtIsbn.Location = new Point(88, 79);
            txtIsbn.Margin = new Padding(2);
            txtIsbn.Name = "txtIsbn";
            txtIsbn.Size = new Size(106, 23);
            txtIsbn.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 78);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 9;
            label5.Text = "ISBN";
            // 
            // txtTitel
            // 
            txtTitel.Location = new Point(90, 49);
            txtTitel.Margin = new Padding(2);
            txtTitel.Name = "txtTitel";
            txtTitel.Size = new Size(106, 23);
            txtTitel.TabIndex = 8;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtName);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txtId);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtLastname);
            groupBox2.Location = new Point(8, 7);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(531, 85);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Author";
            // 
            // dgvBook
            // 
            dgvBook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBook.Location = new Point(8, 207);
            dgvBook.Margin = new Padding(2);
            dgvBook.Name = "dgvBook";
            dgvBook.RowHeadersWidth = 62;
            dgvBook.RowTemplate.Height = 33;
            dgvBook.Size = new Size(531, 178);
            dgvBook.TabIndex = 10;
            // 
            // frmAuthorU
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 386);
            Controls.Add(dgvBook);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(2);
            Name = "frmAuthorU";
            Text = "frmAuthorU";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBook).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSave;
        private Label label1;
        private Label label2;
        private TextBox txtName;
        private TextBox txtLastname;
        private Label label3;
        private TextBox txtId;
        private Label label4;
        private GroupBox groupBox1;
        private TextBox txtTitel;
        private GroupBox groupBox2;
        private Button btnDelete;
        private Button btnAdd;
        private TextBox txtBookId;
        private Label label6;
        private TextBox txtIsbn;
        private Label label5;
        private DataGridView dgvBook;
    }
}