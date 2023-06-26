using UC7.Services;

namespace UC7.Tests
{
    public class PlayerFixture
    {
        public PlayerFixture()
        {
            this.PlayerAnalyzer = new PlayerAnalyzer();
        }

        public PlayerAnalyzer PlayerAnalyzer { get; }
    }
}
