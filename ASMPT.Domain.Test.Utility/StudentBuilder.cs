

namespace ASMPT.Domain.Test.Utility
{
    public class StudentBuilder
    {
        private int _id;
        private string _name;
        private string _email;
        private int  _addressId;
        private string _street;
        private string _houseNumber;
        private string _postalCode;
        private string _city;
        private string _surename;

        public StudentBuilder()
        {
            
        }

        public StudentBuilder WithName(string name)
        {
            this._name = name;
            return this;
        }

        public StudentBuilder WithSurename(string surename)
        {
            this._surename = surename;
            return this;
        }

        public StudentBuilder WithEmail(string email)
        {
            this._email = email;
            return this;
        }

        public StudentBuilder WithStudentId(int id)
        {
            this._id = id;
            return this;
        }


        public Student Build()
        {
            return new Student(_id, _name,_surename, _email, _addressId, new Address(_addressId, _street, _houseNumber, _postalCode, _city)); 
          
        }
    }
}