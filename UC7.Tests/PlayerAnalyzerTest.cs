using UC7.Models;

namespace UC7.Tests
{
    public class PlayerAnalyzerTest : IClassFixture<PlayerFixture>
    {
        private readonly PlayerFixture playerFixture;

        public PlayerAnalyzerTest(PlayerFixture PlayerFixture)
        {
            this.playerFixture = PlayerFixture;
        }

        [Fact]
        public void NormalPlayer()
        {
            var given = new List<Player>
            {
                new Player{ Age = 25 , Experience = 5, Skills = { 2,2,2 }}
            };

            var actual = playerFixture.PlayerAnalyzer.CalculateScore(given);

            Assert.Equal(250, actual);
        }

        [Fact]
        public void JuniorPlayer()
        {
            var given = new List<Player>
            {
                new Player{ Age = 15 , Experience = 3, Skills = { 3,3,3 }}
            };

            var actual = playerFixture.PlayerAnalyzer.CalculateScore(given);

            Assert.Equal(67.5, actual);
        }

        [Fact]
        public void SeniorPlayer()
        {
            var given = new List<Player>
            {
                new Player{ Age = 35 , Experience = 15, Skills = { 4,4,4 }}
            };

            var actual = playerFixture.PlayerAnalyzer.CalculateScore(given);

            Assert.Equal(2520, actual);
        }

        [Fact]
        public void MultiplePlayers()
        {
            var given = new List<Player>
            {
                new Player{ Age = 25 , Experience = 5, Skills = { 2,2,2 }},
                new Player{ Age = 15 , Experience = 3, Skills = { 3,3,3 }},
                new Player{ Age = 35 , Experience = 15, Skills = { 4,4,4 }}
            };

            var actual = playerFixture.PlayerAnalyzer.CalculateScore(given);

            var expected = 250 + 67.5 + 2520;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SkillIsNull()
        {
            var given = new List<Player>
            {
                new Player{ Age = 25 , Experience = 5, Skills = { 2,2,2 }}
            };

            var actual = playerFixture.PlayerAnalyzer.CalculateScore(given);

            Assert.Equal(250, actual);
        }


        [Fact]
        public void EmptyArray()
        {
            var given = new List<Player>();

            var actual = playerFixture.PlayerAnalyzer.CalculateScore(given);

            Assert.Equal(0,actual);
        }
    }
}