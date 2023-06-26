using UC7.Models;

namespace UC7.Tests
{
    public class StudentConverterTest : IClassFixture<StudentFixture>
    {
        private readonly StudentFixture studentFixture;

        public StudentConverterTest(StudentFixture studentFixture)
        {
            this.studentFixture = studentFixture;
        }

        [Fact]
        public void HighAchiever()
        {
            var given = new List<Student>
            {
                new Student{ Age = 21 , Grade = 91},
                new Student{ Age = 22 , Grade = 101},
                new Student{ Age = 23 , Grade = 131},
                new Student{ Age = 24 , Grade = 150},
                new Student{ Age = 25 , Grade = 200},
            };

            var actual = studentFixture.StudentConverter.ConvertStudents(given);

            Assert.All(actual, item => Assert.True(item.HonorRoll));
        }

        [Fact]
        public void ExceptionalYoungHighAchiever()
        {
            var given = new List<Student>
            {
                new Student{ Age = 20 , Grade = 91},
                new Student{ Age = 19 , Grade = 101},
                new Student{ Age = 18 , Grade = 131},
                new Student{ Age = 17 , Grade = 150},
                new Student{ Age = 20 , Grade = 200},
            };

            var actual = studentFixture.StudentConverter.ConvertStudents(given);

            Assert.All(actual, item => Assert.True(item.Exceptional));
        }

        [Fact]
        public void PassedStudent()
        {
            var given = new List<Student>
            {
                new Student{ Age = 21 , Grade = 71},
                new Student{ Age = 22 , Grade = 75},
                new Student{ Age = 23 , Grade = 80},
                new Student{ Age = 24 , Grade = 89},
                new Student{ Age = 25 , Grade = 90},
            };

            var actual = this.studentFixture.StudentConverter.ConvertStudents(given);

            Assert.All(actual, item => Assert.True(item.Passed));
        }

        [Fact]
        public void FailedStudent()
        {
            var given = new List<Student>
            {
                new Student{ Age = 21 , Grade = 70},
                new Student{ Age = 22 , Grade = 65},
                new Student{ Age = 23 , Grade = 60},
                new Student{ Age = 24 , Grade = 50},
                new Student{ Age = 25 , Grade = 45},
            };

            var actual = this.studentFixture.StudentConverter.ConvertStudents(given);

            Assert.All(actual, item => Assert.False(item.Passed));
        }

        [Fact]
        public void EmptyArray()
        {
            var given = new List<Student>();

            var actual = this.studentFixture.StudentConverter.ConvertStudents(given);

            Assert.Empty(actual);
        }
    }
}