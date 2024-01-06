using System.Runtime.Serialization;
namespace ASMPT.Domain
{
    public class InvalidBokkISBNException : Exception
    {
        public string ISBN { get; set; }
        public InvalidBokkISBNException(string isbn)
        {
            this.ISBN = isbn;
        }
    }
}