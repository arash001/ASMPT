namespace ASMPTUIWinForm
{
    partial class frmAuthorL
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
            button1 = new Button();
            dgvAuthor = new DataGridView();
            dgvBook = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvAuthor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBook).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(27, 26);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(78, 20);
            button1.TabIndex = 0;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dgvAuthor
            // 
            dgvAuthor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAuthor.Location = new Point(27, 59);
            dgvAuthor.Margin = new Padding(2, 2, 2, 2);
            dgvAuthor.Name = "dgvAuthor";
            dgvAuthor.RowHeadersWidth = 62;
            dgvAuthor.RowTemplate.Height = 33;
            dgvAuthor.Size = new Size(380, 483);
            dgvAuthor.TabIndex = 1;
            // 
            // dgvBook
            // 
            dgvBook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBook.Location = new Point(411, 59);
            dgvBook.Margin = new Padding(2, 2, 2, 2);
            dgvBook.Name = "dgvBook";
            dgvBook.RowHeadersWidth = 62;
            dgvBook.RowTemplate.Height = 33;
            dgvBook.Size = new Size(466, 483);
            dgvBook.TabIndex = 2;
            // 
            // frmAuthorL
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 553);
            Controls.Add(dgvBook);
            Controls.Add(dgvAuthor);
            Controls.Add(button1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "frmAuthorL";
            Text = "frmAuthorL";
            ((System.ComponentModel.ISupportInitialize)dgvAuthor).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBook).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private DataGridView dgvAuthor;
        private DataGridView dgvBook;
    }
}