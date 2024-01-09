using ASMPT.Domain;

namespace ASMPT.Domain.Test.Utility
{
    public class AuthorBuilder
    {
        private int _id;
        private string _surename;
        private string _name;
        private List<Book> _books;
        public AuthorBuilder()
        {
            _id = 1;
            _name = "authorname";
            _surename = "surename";
            _books = new List<Book>();
        }

        public AuthorBuilder WithName(string name)
        {
            this._name = name;
            return this;
        }

        public AuthorBuilder WithSurename(string surename)
        {
            this._surename = surename;
            return this;
        }


        public AuthorBuilder WithId(int id)
        {
            this._id = id;
            return this;
        }

        public AuthorBuilder WithBook(Action<BookBuilder> buildAction)
        {
            var bookBuilder = new BookBuilder();
            buildAction.Invoke(bookBuilder);
            _books.Add(bookBuilder.Build());
            return this;
        }


        public Author Build()
        {
            return new Author(this._id, this._name, this._surename, _books);

        }
    }
}