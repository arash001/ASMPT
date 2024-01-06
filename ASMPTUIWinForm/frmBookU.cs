using ASMPTUIWinForm.Model;
using ASMPTUIWinForm.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASMPTUIWinForm
{
    public partial class frmBookU : Form
    {
        BookService _bookService;
        public frmBookU()
        {
            InitializeComponent();
            _bookService = new BookService();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             CreateBooks();
        }

        private async void CreateBooks()
        {
            Book book = new Book();

            book.Title=txtTitel.Text;
            book.ISBN=txtISBN.Text;

            var result = await _bookService.CreateBooks(book);
            if (result != null)
            {
                MessageBox.Show($"Book ID: {result.NewId}\nTitle: {result.Title}\nMessage: {result.Message}", "API Response", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearAll();
            }

        }

        private void ClearAll()
        {
            txtISBN.Text = string.Empty;
            txtTitel.Text = string.Empty;
        }
    }
}
