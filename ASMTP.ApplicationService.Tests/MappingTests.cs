using ASMPT.ApplicationService.Convertor;
using ASMPT.Data.Contract.ViewModel;
using ASMPT.Domain;
using AutoMapper;
using Xunit;

namespace ASMTP.ApplicationService.Tests
{
    public class MappingTests
    {
        private readonly IMapper _mapper;
        public MappingTests()
        {
            var config = new MapperConfiguration(cfg => cfg.AddProfile<AutoMapperProfile>());
            this._mapper = config.CreateMapper();
        }

        [Fact]
        public void Should_Map_StudentDto_To_Student_Correctly()
        {
         
            var studentDto = new StudentDto
            {
                Id = 1,
                Name = "John",
                Surename = "Doe",
                Email = "john.doe@example.com",
                AddressId = 123,
            };

            // Act
            var student = _mapper.Map<Student>(studentDto);

            // Assert
            Assert.Equal(studentDto.Id, student.Id);
            Assert.Equal(studentDto.Name, student.Name);
            Assert.Equal(studentDto.Surename, student.Surename);
            Assert.Equal(studentDto.Email, student.Email);
            Assert.Equal(studentDto.AddressId, student.AddressId);
        }
    }

}