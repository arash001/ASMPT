namespace ASMPTUIWinForm.Model
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surename { get; set; }
        public string Email { get; set; }
        public int AddressId { get; set; }
        public Address address { get; set; }
    }

}
