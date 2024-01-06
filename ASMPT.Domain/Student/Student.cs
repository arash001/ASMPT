using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Threading.Tasks;
using ASMPT.Domain.Utility;

namespace ASMPT.Domain
{
    // Define the Student class
    public class Student
    { 
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surename { get; set; }
        public string Email { get; set; }
        public int AddressId { get; set; } 
        public virtual Address Address { get; set; }
        public Student()
        {
            
        }
        public Student(int id, string name, string surename, string email, int addressId, Address address)
        {
            SetProperties(id, name, surename, email, addressId, address);
        }

       

        private void SetProperties(int id, string name, string surename, string email, int addressId, Address address)
        {
            Id = id;
            Name = name;
            Surename = surename;
            Email = email;
            AddressId = addressId;
            Address = address;

            if (string.IsNullOrEmpty(name) ) throw new InvalidStudentNameException();
            if (string.IsNullOrEmpty(surename) ) throw new InvalidStudentSurenameException();
            if (string.IsNullOrEmpty(email) ) throw new InvalidEmailNameException();
            if (!email.IsValidEmail() ) throw new InvalidEmailFormatException();
        }
    }
}