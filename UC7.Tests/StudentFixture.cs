using UC7.Services;

namespace UC7.Tests
{
    public class StudentFixture
    {
        public StudentFixture()
        {
            this.StudentConverter = new StudentConverter();
        }

        public StudentConverter StudentConverter { get; }
    }
}
