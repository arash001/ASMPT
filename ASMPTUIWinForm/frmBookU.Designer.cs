﻿namespace ASMPTUIWinForm
{
    partial class frmBookU
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
            button1 = new Button();
            txtISBN = new TextBox();
            txtTitel = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txtISBN);
            groupBox1.Controls.Add(txtTitel);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(314, 150);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Create Book";
            // 
            // button1
            // 
            button1.Location = new Point(228, 113);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(119, 71);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(100, 23);
            txtISBN.TabIndex = 3;
            // 
            // txtTitel
            // 
            txtTitel.Location = new Point(119, 35);
            txtTitel.Name = "txtTitel";
            txtTitel.Size = new Size(100, 23);
            txtTitel.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 74);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 1;
            label2.Text = "ISBN";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 35);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 0;
            label1.Text = "Title";
            // 
            // frmBookU
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 179);
            Controls.Add(groupBox1);
            Name = "frmBookU";
            Text = "frmBookU";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox txtISBN;
        private TextBox txtTitel;
    }
}