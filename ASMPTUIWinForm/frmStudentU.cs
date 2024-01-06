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
    public partial class frmStudentU : Form
    {
        public frmStudentU()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveStudentAsync();

        }

        private async Task SaveStudentAsync()
        {

            StudentService studentService = new StudentService();
            Student student = new Student();
            student.Name = txtName.Text;
            student.Surename = txtLastname.Text;
            student.Email=txtEmail.Text;
            student.address = new Address()
            {
                City = txtCity.Text,
                HouseNumber = txtHouseNumber.Text,
                PostalCode = txtPostalCode.Text,
                Street = txtStreet.Text
            };

            var result = await studentService.CreateStudentAsync(student);

            if (result != null)
            {
                MessageBox.Show($"Author ID: {result.NewId}\nTitle: {result.Title}\nMessage: {result.Message}", "API Response", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearAll();
            }
            else
            {
                MessageBox.Show("Failed to save Student. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void ClearAll()
        {
            txtId.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtHouseNumber.Text = string.Empty;
            txtPostalCode.Text = string.Empty;
            txtStreet.Text = string.Empty;
            txtName.Text = string.Empty;
            txtLastname.Text = string.Empty;
            txtEmail.Text= string.Empty;
        }
    }
}

