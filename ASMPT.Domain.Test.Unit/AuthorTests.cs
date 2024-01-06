
using ASMPT.Domain.Test.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ASMPT.Domain
{
    public class AuthorTests
    {
        private readonly AuthorBuilder _authorBuilder;
        public AuthorTests(AuthorBuilder authorBuilder)
        {
            _authorBuilder = authorBuilder;
        }
        public static IEnumerable<object[]> InvalidStringName()
        {
            yield return new object[] { "" };
            yield return new object[] { string.Empty };
        }

        [Theory]
        [MemberData(nameof(InvalidStringName))]
        public void When_AuthorName_Is_NullorEmpty_Throw_Exception(string name)
        {
            var id = 1;
            var address = new Address(1, "Meunchen", "23", "streetname", "81737");
            var addressId = 1;
            var surename = "surename";
            _authorBuilder.WithtId(id).WithName(name).WithSurename(surename);

            Assert.Throws<InvalidAuthorNameException>(() =>
            {
                var student = _authorBuilder.Build();

            });
        }
    }
}
