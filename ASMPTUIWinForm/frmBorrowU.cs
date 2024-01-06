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
    public partial class frmBorrowU : Form
    {
        private readonly StudentService _studentService;
        private readonly BookService _bookService;
        List<Borrow> Borrows = new List<Borrow>();
        public frmBorrowU()
        {
            InitializeComponent();
            _studentService = new StudentService();
            _bookService = new BookService();
            GetStudnets();
            GetBooks();
        }


        private async Task GetStudnets()
        {
            try
            {
                var students = await _studentService.GetStudentsModelAsync();
                cmbStudent.DataSource = students;
                cmbStudent.DisplayMember = "name";
                cmbStudent.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private async Task GetBooks()
        {
            try
            {
                var books = await _bookService.GetModelBooks();
                cmbbook.DataSource = books;
                cmbbook.DisplayMember = "titl";
                cmbbook.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BorrowService borrowService = new BorrowService();

            CreateBorrow borrowObj = new CreateBorrow()
            {
                BookId = Convert.ToInt32(cmbbook.SelectedValue),
                StudentId = Convert.ToInt32(cmbStudent.SelectedValue),
                StartDate = startdateTimePicker1.Value,
                EndDate = enddateTimePicker2.Value,
            };


            borrowService.CreateBorrow(borrowObj);
        }
    }
}
