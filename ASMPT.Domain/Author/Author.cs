using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace ASMPT.Domain
{
    // Define the Author class
  
        public class Author
        {
        [Key]
        public int Id { get; set; }
            public string Name { get; set; }
            public string Surename { get; set; }

            public virtual ICollection<Book>? Book { get; set; }   // Navigation property for books written by this author

        public Author(int id, string name, string surname, ICollection<Book> books)
        {
            Book = new List<Book>();
            SetProperties(id, name, surname, books);
        }

        public Author()
        {
        }

        private void SetProperties(int id, string name, string surename, ICollection<Book> books)
        {
            Id = id;
            Name = name;
            Surename = surename;
            Book = books;

            if (string.IsNullOrEmpty(name)) throw new InvalidAuthorNameException();
            if (string.IsNullOrEmpty(surename)) throw new InvalidAuthorSurenameException();
        }
    }

    

}