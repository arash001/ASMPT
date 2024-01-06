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
            btnSave.Location = new Point(627, 121);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(111, 42);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 92);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 1;
            label1.Text = "Name";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 44);
            label2.Name = "label2";
            label2.Size = new Size(96, 25);
            label2.TabIndex = 2;
            label2.Text = "Nachname";
            // 
            // txtName
            // 
            txtName.Location = new Point(129, 92);
            txtName.Name = "txtName";
            txtName.Size = new Size(150, 31);
            txtName.TabIndex = 3;
            // 
            // txtLastname
            // 
            txtLastname.Location = new Point(129, 44);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(150, 31);
            txtLastname.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(398, 19);
            label3.Name = "label3";
            label3.Size = new Size(30, 25);
            label3.TabIndex = 5;
            label3.Text = "ID";
            label3.TextAlign = ContentAlignment.TopCenter;
            label3.Visible = false;
            // 
            // txtId
            // 
            txtId.Location = new Point(453, 14);
            txtId.Name = "txtId";
            txtId.Size = new Size(150, 31);
            txtId.TabIndex = 6;
            txtId.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(62, 83);
            label4.Name = "label4";
            label4.Size = new Size(44, 25);
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
            groupBox1.Location = new Point(11, 160);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(780, 178);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "book";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(337, 78);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(111, 42);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(337, 33);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(111, 42);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtBookId
            // 
            txtBookId.Location = new Point(129, 33);
            txtBookId.Name = "txtBookId";
            txtBookId.Size = new Size(150, 31);
            txtBookId.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(76, 30);
            label6.Name = "label6";
            label6.Size = new Size(30, 25);
            label6.TabIndex = 7;
            label6.Text = "ID";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtIsbn
            // 
            txtIsbn.Location = new Point(129, 132);
            txtIsbn.Name = "txtIsbn";
            txtIsbn.Size = new Size(150, 31);
            txtIsbn.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(56, 130);
            label5.Name = "label5";
            label5.Size = new Size(50, 25);
            label5.TabIndex = 9;
            label5.Text = "ISBN";
            // 
            // txtTitel
            // 
            txtTitel.Location = new Point(129, 82);
            txtTitel.Name = "txtTitel";
            txtTitel.Size = new Size(150, 31);
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
            groupBox2.Location = new Point(11, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(780, 152);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Author";
            // 
            // dgvBook
            // 
            dgvBook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBook.Location = new Point(11, 344);
            dgvBook.Name = "dgvBook";
            dgvBook.RowHeadersWidth = 62;
            dgvBook.RowTemplate.Height = 33;
            dgvBook.Size = new Size(780, 342);
            dgvBook.TabIndex = 10;
            // 
            // frmAuthorU
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 691);
            Controls.Add(dgvBook);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
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