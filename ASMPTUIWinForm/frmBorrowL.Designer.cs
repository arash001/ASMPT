namespace ASMPTUIWinForm
{
    partial class frmBorrowL
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
            groupBox2 = new GroupBox();
            txtStudentId = new TextBox();
            label2 = new Label();
            btnStudentSearch = new Button();
            groupBox3 = new GroupBox();
            txtBookId = new TextBox();
            label3 = new Label();
            btnBookSearch = new Button();
            BorrowList = new GroupBox();
            dgvBorrow = new DataGridView();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            BorrowList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBorrow).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtStudentId);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(btnStudentSearch);
            groupBox2.Location = new Point(32, 21);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(308, 56);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Search";
            // 
            // txtStudentId
            // 
            txtStudentId.Location = new Point(115, 22);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(100, 23);
            txtStudentId.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 25);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 2;
            label2.Text = "Student Number";
            // 
            // btnStudentSearch
            // 
            btnStudentSearch.Location = new Point(221, 22);
            btnStudentSearch.Name = "btnStudentSearch";
            btnStudentSearch.Size = new Size(75, 23);
            btnStudentSearch.TabIndex = 0;
            btnStudentSearch.Text = "Search";
            btnStudentSearch.UseVisualStyleBackColor = true;
            btnStudentSearch.Click += button1_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtBookId);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(btnBookSearch);
            groupBox3.Location = new Point(346, 21);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(308, 56);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Search";
            // 
            // txtBookId
            // 
            txtBookId.Location = new Point(115, 22);
            txtBookId.Name = "txtBookId";
            txtBookId.Size = new Size(100, 23);
            txtBookId.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 25);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 2;
            label3.Text = "Book Number";
            // 
            // btnBookSearch
            // 
            btnBookSearch.Location = new Point(221, 22);
            btnBookSearch.Name = "btnBookSearch";
            btnBookSearch.Size = new Size(75, 23);
            btnBookSearch.TabIndex = 0;
            btnBookSearch.Text = "Search";
            btnBookSearch.UseVisualStyleBackColor = true;
            btnBookSearch.Click += btnBookSearch_Click;
            // 
            // BorrowList
            // 
            BorrowList.Controls.Add(dgvBorrow);
            BorrowList.Location = new Point(32, 83);
            BorrowList.Name = "BorrowList";
            BorrowList.Size = new Size(622, 289);
            BorrowList.TabIndex = 5;
            BorrowList.TabStop = false;
            BorrowList.Text = "Borrow List";
            // 
            // dgvBorrow
            // 
            dgvBorrow.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBorrow.Location = new Point(14, 27);
            dgvBorrow.Name = "dgvBorrow";
            dgvBorrow.RowTemplate.Height = 25;
            dgvBorrow.Size = new Size(596, 249);
            dgvBorrow.TabIndex = 0;
            // 
            // frmBorrowL
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(669, 399);
            Controls.Add(BorrowList);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Name = "frmBorrowL";
            Text = "frmBorrowL";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            BorrowList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBorrow).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private TextBox txtStudentId;
        private Label label2;
        private Button btnStudentSearch;
        private GroupBox groupBox3;
        private TextBox txtBookId;
        private Label label3;
        private Button btnBookSearch;
        private GroupBox BorrowList;
        private DataGridView dgvBorrow;
    }
}