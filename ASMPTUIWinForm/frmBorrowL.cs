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
    public partial class frmBorrowL : Form
    {
        BorrowService _borrowService;
        public frmBorrowL()
        {
            InitializeComponent();
             _borrowService = new BorrowService();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result=_borrowService.GetBorrowByStudentAsync(Convert.ToInt32(txtStudentId.Text));
            dgvBorrow.DataSource = result.Result;
          

        }

        private void btnBookSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
