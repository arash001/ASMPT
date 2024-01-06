using ASMPT.Domain;

namespace ASMPT.Domain.Test.Utility
{
    public class AuthorBuilder
    {
private int _id;
        private string _surename;
        private string _name;

        public AuthorBuilder()
        {
            
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


        public AuthorBuilder WithtId(int id)
        {
            this._id = id;
            return this;
        }


        public Author Build()
        {
            return new Author(this._id,this._name,this._surename,new List<Book>());
          
        }
    }
}