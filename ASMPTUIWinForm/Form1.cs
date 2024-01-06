using ASMPTUIWinForm.Service;

namespace ASMPTUIWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var key = "https://nuget.devexpress.com/DCWmdgrhcYYFPbgaahxfM5hTZAk3UvBR3lRolJkb8mNrtzhLVx/api/v3/index.json";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void studentgToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void authorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AuthorService authorService = new AuthorService();

            frmAuthorL frmAuthorL = new frmAuthorL(authorService);
            frmAuthorL.ShowDialog();

        }

        private void createToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmBorrowU _frmBorrowU = new frmBorrowU();
            _frmBorrowU.ShowDialog();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBorrowL _frmBorrowL = new frmBorrowL();
            _frmBorrowL.ShowDialog();
        }

        private void createToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmAuthorU _frmAuthorU = new frmAuthorU();
            _frmAuthorU.ShowDialog();
        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmBookL frmBookL = new frmBookL();
            frmBookL.ShowDialog();
        }

        private void createToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmBookU frmBookU = new frmBookU();
            frmBookU.ShowDialog();
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStudentL frmStudentL = new frmStudentL();
            frmStudentL.ShowDialog();
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStudentU frmStudentU=new frmStudentU();
            frmStudentU.ShowDialog();
        }
    }
}