using ASMPTUIWinForm.Model;
using ASMPTUIWinForm.Service;
using Newtonsoft.Json;
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
    public partial class frmAuthorL : Form
    {
        private const string BaseUrl = "https://localhost:7258/api/Borrow/";
        private int studentId = 1;
        private readonly AuthorService _authorService;
        private readonly List<Student> _students;
        public frmAuthorL(AuthorService authorService)
        {
            InitializeComponent();
            _authorService = authorService;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetAuthorApiList();
        }
        private async Task GetAuthorApiList()
        {
            try
            {
                var authors = await _authorService.GetDataAsync<Author>();
                dgvAuthor.DataSource = authors;
                //dgvAuthor.DataMember = "author";
                dgvAuthor.SelectionChanged += dgvAuthor_SelectionChanged;
                // Process the retrieved author data as needed
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void dgvAuthor_SelectionChanged(object sender, EventArgs e)
        {
            // When the selection changes in the master DataGridView, update the details DataGridView
            DisplayAuthorDetails();
        }
        private void DisplayAuthorDetails()
        {
            // Get the selected author from the master DataGridView
            DataGridViewCell selectedCell = dgvAuthor.CurrentCell;

            // Ensure a cell is selected and that it belongs to the "Authors" column
            if (selectedCell != null)
            {
                // Get the selected author from the DataBoundItem of the row
                Author selectedAuthor = dgvAuthor.Rows[selectedCell.RowIndex].DataBoundItem as Author;

                // Display the details of the selected author in the details DataGridView
                dgvBook.DataSource = selectedAuthor?.book;
            }
        }


    }
}
