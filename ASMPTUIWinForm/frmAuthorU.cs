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
    public partial class frmAuthorU : Form
    {
        Author authorObj = new Author();
        List<Book> books = new List<Book>();
        public frmAuthorU()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Book book = new Book();

            book.Id = (int.Parse(txtBookId.Text));
            txtBookId.Text = (book.Id + 1).ToString();

            book.Title = txtTitel.Text;
            book.ISBN = txtIsbn.Text;
            books.Add(book);

            var bindingList = new BindingList<Book>(books);

            var source = new BindingSource(bindingList, null);

            dgvBook.DataSource = source;
            ClearTextForBook();
        }

        private void ClearAll()
        {
            ClearTextForBook();

            txtId.Text = string.Empty;
            txtName.Text = string.Empty;
            txtLastname.Text = string.Empty;
            books.Clear();
            dgvBook.DataSource = null;
            dgvBook.Rows.Clear();
            dgvBook.Refresh();
        }
        private void ClearTextForBook()
        {

            txtBookId.Text = string.Empty;
            txtTitel.Text = string.Empty;
            txtIsbn.Text = string.Empty;
        }

        private int bookIdCounter = 1; // Initialize the counter
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteBook();
        }

        private void DeleteBook()
        {
            if (dgvBook.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvBook.SelectedRows[0];
                int selectedBookId = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                var result = books.FirstOrDefault(r => r.Id == selectedBookId);

                if (result != null)
                {
                    books.Remove(result);

                    var bindingList = new BindingList<Book>(books);
                    var source = new BindingSource(bindingList, null);

                    dgvBook.DataSource = source;
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            await Save();

        }

        private async Task Save()
        {
            AuthorService authorService = new AuthorService();
            //  authorObj.id = Convert.ToInt32( txtId.Text);
            authorObj.name = txtName.Text;
            authorObj.surename = txtName.Text;
            authorObj.book = books.Select(b => new Book { Title = b.Title, ISBN = b.ISBN }).ToList();

            var result = await authorService.CreateAuthorAsync(authorObj);

            if (result != null)
            {
                MessageBox.Show($"Author ID: {result.NewId}\nTitle: {result.Title}\nMessage: {result.Message}", "API Response", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearAll();
            }
            else
            {
                MessageBox.Show("Failed to save author. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
