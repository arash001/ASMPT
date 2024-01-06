namespace ASMPTUIWinForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            baseInfoToolStripMenuItem = new ToolStripMenuItem();
            authorToolStripMenuItem1 = new ToolStripMenuItem();
            createToolStripMenuItem2 = new ToolStripMenuItem();
            borrowToolStripMenuItem1 = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            createToolStripMenuItem1 = new ToolStripMenuItem();
            studentgToolStripMenuItem = new ToolStripMenuItem();
            listToolStripMenuItem = new ToolStripMenuItem();
            createToolStripMenuItem = new ToolStripMenuItem();
            bookToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem1 = new ToolStripMenuItem();
            createToolStripMenuItem3 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { baseInfoToolStripMenuItem, borrowToolStripMenuItem1, studentgToolStripMenuItem, bookToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(4, 1, 0, 1);
            menuStrip1.Size = new Size(1033, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // baseInfoToolStripMenuItem
            // 
            baseInfoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { authorToolStripMenuItem1, createToolStripMenuItem2 });
            baseInfoToolStripMenuItem.Name = "baseInfoToolStripMenuItem";
            baseInfoToolStripMenuItem.Size = new Size(56, 22);
            baseInfoToolStripMenuItem.Text = "Author";
            // 
            // authorToolStripMenuItem1
            // 
            authorToolStripMenuItem1.Name = "authorToolStripMenuItem1";
            authorToolStripMenuItem1.Size = new Size(124, 22);
            authorToolStripMenuItem1.Text = "Open List";
            authorToolStripMenuItem1.Click += authorToolStripMenuItem1_Click;
            // 
            // createToolStripMenuItem2
            // 
            createToolStripMenuItem2.Name = "createToolStripMenuItem2";
            createToolStripMenuItem2.Size = new Size(124, 22);
            createToolStripMenuItem2.Text = "Create";
            createToolStripMenuItem2.Click += createToolStripMenuItem2_Click;
            // 
            // borrowToolStripMenuItem1
            // 
            borrowToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, createToolStripMenuItem1 });
            borrowToolStripMenuItem1.Name = "borrowToolStripMenuItem1";
            borrowToolStripMenuItem1.Size = new Size(57, 22);
            borrowToolStripMenuItem1.Text = "Borrow";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(108, 22);
            openToolStripMenuItem.Text = "List";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // createToolStripMenuItem1
            // 
            createToolStripMenuItem1.Name = "createToolStripMenuItem1";
            createToolStripMenuItem1.Size = new Size(108, 22);
            createToolStripMenuItem1.Text = "Create";
            createToolStripMenuItem1.Click += createToolStripMenuItem1_Click;
            // 
            // studentgToolStripMenuItem
            // 
            studentgToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listToolStripMenuItem, createToolStripMenuItem });
            studentgToolStripMenuItem.Name = "studentgToolStripMenuItem";
            studentgToolStripMenuItem.Size = new Size(60, 22);
            studentgToolStripMenuItem.Text = "Student";
            studentgToolStripMenuItem.Click += studentgToolStripMenuItem_Click;
            // 
            // listToolStripMenuItem
            // 
            listToolStripMenuItem.Name = "listToolStripMenuItem";
            listToolStripMenuItem.Size = new Size(180, 22);
            listToolStripMenuItem.Text = "List";
            listToolStripMenuItem.Click += listToolStripMenuItem_Click;
            // 
            // createToolStripMenuItem
            // 
            createToolStripMenuItem.Name = "createToolStripMenuItem";
            createToolStripMenuItem.Size = new Size(180, 22);
            createToolStripMenuItem.Text = "Create";
            createToolStripMenuItem.Click += createToolStripMenuItem_Click;
            // 
            // bookToolStripMenuItem
            // 
            bookToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem1, createToolStripMenuItem3 });
            bookToolStripMenuItem.Name = "bookToolStripMenuItem";
            bookToolStripMenuItem.Size = new Size(46, 22);
            bookToolStripMenuItem.Text = "Book";
            // 
            // openToolStripMenuItem1
            // 
            openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            openToolStripMenuItem1.Size = new Size(108, 22);
            openToolStripMenuItem1.Text = "List";
            openToolStripMenuItem1.Click += openToolStripMenuItem1_Click;
            // 
            // createToolStripMenuItem3
            // 
            createToolStripMenuItem3.Name = "createToolStripMenuItem3";
            createToolStripMenuItem3.Size = new Size(108, 22);
            createToolStripMenuItem3.Text = "Create";
            createToolStripMenuItem3.Click += createToolStripMenuItem3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1033, 619);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem baseInfoToolStripMenuItem;
        private ToolStripMenuItem authorToolStripMenuItem1;
        private ToolStripMenuItem borrowToolStripMenuItem1;
        private ToolStripMenuItem studentgToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem createToolStripMenuItem1;
        private ToolStripMenuItem listToolStripMenuItem;
        private ToolStripMenuItem createToolStripMenuItem;
        private ToolStripMenuItem createToolStripMenuItem2;
        private ToolStripMenuItem bookToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem1;
        private ToolStripMenuItem createToolStripMenuItem3;
    }
}