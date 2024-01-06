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
    public partial class frmStudentL : Form
    {
        StudentService _studentService;
        public frmStudentL()
        {
            InitializeComponent();
            _studentService = new StudentService();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetStudent();
        }

        private async void GetStudent()
        {
           var result=  await _studentService.GetStudentsAsync();
            dgvStudent.DataSource = result;
        }
    }
}
