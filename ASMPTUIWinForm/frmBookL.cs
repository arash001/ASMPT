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
    public partial class frmBookL : Form
    {
        BookService _bookService;
        public frmBookL()
        {
            InitializeComponent();
            _bookService = new BookService();
        }

        private void frmBookL_Load(object sender, EventArgs e)
        {
        
        }

        private async void GetBooks()
        {
            var result =await _bookService.GetBooks();
            dgvBook.DataSource = result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetBooks();
        }
    }
}
