namespace ASMPTUIWinForm.Model
{
    public class CreateBorrow
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int StudentId { get; set; }
        public int BookId { get; set; }
    }
}
