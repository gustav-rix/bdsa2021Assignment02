using System;
using Xunit;

namespace Assignment02.Tests
{
    public class StudentTests
    {
        [Fact]
        public void Student_to_string_works()
        {
            //Assert
            var s = new Student {Id = 1, GivenName = "Markus", Surname = "Hansen",Status = new Status(), StartDate = new DateTime(2021, 9, 22, 10, 30, 50), EndDate =  new DateTime(2022, 9, 23, 10, 30, 50), GraduationDate =  new DateTime(2023, 12, 30, 10, 30, 50)};
            
            //Arrange
            var expected = s.ToString();
            var actual = "Id: 1 , GivenName: Markus , Surname: Hansen , Status: New , StartDate: 22-09-2021 10:30:50 , EndDate: 23-09-2022 10:30:50 , GraduationDate: 30-12-2023 10:30:50";
            //Act
             Assert.Equal(expected,actual);
        }

    }
}
