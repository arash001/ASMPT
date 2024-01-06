using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace ASMPT.Domain
{

    public class Address
    {
        [Key]
        [ForeignKey("Student")]
        public int Id { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public virtual Student Student { get; set; }

        public Address(int id, string street, string houseNumber, string postalCode, string city)
        {
            SetProperties(id, street, houseNumber, postalCode, city);
        }

        private void SetProperties(int id, string street, string houseNumber, string postalCode, string city)
        {
            Id = id;
            Street = street;
            HouseNumber = houseNumber;
            PostalCode = postalCode;
            City = city;
        }
    }
}

