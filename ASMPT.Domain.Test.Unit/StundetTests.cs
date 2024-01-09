using ASMPT.Domain.Test.Utility;
using System.Text.RegularExpressions;
using Xunit;

namespace ASMPT.Domain
{
    public class StundetTests
    {
        public static IEnumerable<object[]> InvalidStringName()
        {
            yield return new object[] { "" };
            yield return new object[] { string.Empty };
        }

        public StundetTests()
        {
            _studentBuilder =new  StudentBuilder();
        }


        private readonly StudentBuilder _studentBuilder;


        [Theory]
        [MemberData(nameof(InvalidStringName))]
      public void When_Name_Is_NullorEmpty_Throw_Exception(string name)
        {
            var id = 1;
            var address = new Address(1, "Meunchen", "23", "streetname", "81737");
            var addressId = 1;
            var email = "a@a.com";
            var surename = "surename";
            _studentBuilder.WithStudentId(id).WithName(name).WithSurename(surename).WithEmail(email);

            Assert.Throws<InvalidStudentNameException>(() =>
            {
                var student = _studentBuilder.Build();
        
            });
        }


        [Theory]
        [MemberData(nameof(InvalidStringName))]
        public void When_Family_Is_NullorEmpty_Throw_Exception(string surename)
        {
            var id = 1;
            var address =  new Address(1, "Meunchen", "23", "streetname", "81737");
            var addressId = 1;
            var email = "a@a.com";
            var name = "first name";

            Assert.Throws< InvalidStudentSurenameException> (() =>
            {
                var student = new Student(id, name,surename, email, address.Id, address);

            });
        }


        [Theory]
        [MemberData(nameof(InvalidStringName))]
        public void When_Email_Is_NullorEmpty_Throw_Exception(string email)
        {
            var id = 1;
            var name = "first name";
            var address = new Address(   1,  "Meunchen",  "23",  "streetname",  "81737" );
            var addressId = 1;
            var surename = "surename";

            Assert.Throws<InvalidEmailNameException>(() =>
            {
                var student = new Student(id, name, surename, email, address.Id, address);

            });
        }


        //[Theory]
        //[MemberData(nameof(InvalidStringName))]
        //public void When_Email_Format_Is_Not_Correct_Throw_Exception(string email)
        //{
        //    var id = 1;
        //    var name = "first name";
        //    var address = new Address() { Id = 1, City = "Meunchen", HouseNumber = "23", Street = "streetname", PostalCode = "81737" };
        //    var addressId = 1;
        //    var surename = "surename";

        //    Assert.Throws<Exception>(() =>
        //    {
        //        var student = new Student(id, name, surename, email, address.Id, address);

        //    });
        //}

        //[Theory]
        //[InlineData("test@example.com")]
        //[InlineData("user123@subdomain.example.co.uk")]
        //[InlineData("user@localhost")]
        //[InlineData("john.doe@my-website.net")]
        //public void ValidEmails_ReturnsTrue(string email)
        //{
        //    // Define a regular expression pattern for a valid email format
        //    string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

        //    // Use Regex.IsMatch to check if the email matches the pattern
        //    bool isValid = Regex.IsMatch(email, pattern);

        //    // Assert that the email is valid
        //    Assert.True(isValid);
        //}

        [Theory]
        [InlineData("invalid-email")]
        [InlineData("missing@dotcom")]
        [InlineData("spaces in@email.com")]
        [InlineData("user@.com")]
        [InlineData("@example.com")]
        [InlineData("user@.example")]
        public void InvalidEmails_ReturnsFalse(string email)
        {
            // Define a regular expression pattern for a valid email format
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Use Regex.IsMatch to check if the email matches the pattern
            bool isValid = Regex.IsMatch(email, pattern);

            // Assert that the email is invalid
            Assert.False(isValid);
        }
    }
}