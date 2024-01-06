using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASMPT.Data.Contract;
using ASMPT.Data.Repository;
using ASMPT.Domain;
using ASMTP.Data;
using Microsoft.EntityFrameworkCore;
using NSubstitute;
using Xunit;

public class StudentRepositoryTests
{

 
        //[Fact]
        //public async Task GetByIdAsync_Should_Return_Student()
        //{
        //    // Arrange
        //    var studentId = 1;
        //    var expectedStudent = new Student { Id = studentId, Name = "John", Surename = "Doe", Email = "john.doe@example.com" };

        //    var repository = Substitute.For<IStudentRepository>();
        //    repository.GetById(studentId).Returns(expectedStudent);

        //    // Act
        //    var actualStudent = await repository.GetById(studentId);

        //    // Assert
        //    Assert.Equal(expectedStudent, actualStudent);
        //}

        [Fact]
        public void GetAll_Should_Return_List_Of_Students()
        {
            // Arrange
            var expectedStudents = new List<Student>
        {
            new Student { Id = 1, Name = "John", Surename = "Doe", Email = "john.doe@example.com" },
            new Student { Id = 2, Name = "Jane", Surename = "Smith", Email = "jane.smith@example.com" }
        };

            var repository = Substitute.For<IStudentRepository>();
            repository.GetAll().Returns(expectedStudents);

            // Act
            var actualStudents = repository.GetAll();

            // Assert
            Assert.Equal(expectedStudents, actualStudents);
        }

        [Fact]
        public void Add_Should_Call_Add_Method_In_Repository()
        {
            // Arrange
            var repository = Substitute.For<IStudentRepository>();
            var student = new Student { Id = 1, Name = "John", Surename = "Doe", Email = "john.doe@example.com" };

            // Act
            repository.Add(student);

            // Assert
            repository.Received(1).Add(student);
        }

        [Fact]
        public void Edit_Should_Call_Edit_Method_In_Repository()
        {
            // Arrange
            var repository = Substitute.For<IStudentRepository>();
            var student = new Student { Id = 1, Name = "John", Surename = "Doe", Email = "john.doe@example.com" };

            // Act
            repository.Edit(student);

            // Assert
            repository.Received(1).Edit(student);
        }

        [Fact]
        public void Delete_Should_Call_Delete_Method_In_Repository()
        {
            // Arrange
            var repository = Substitute.For<IStudentRepository>();
            var studentId = 1;

            // Act
            repository.Delete(studentId);

            // Assert
            repository.Received(1).Delete(studentId);
        }

       
    }

