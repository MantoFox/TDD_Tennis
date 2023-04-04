using FluentAssertions;
using NUnit.Framework;

namespace TDD_Tennis
{
    public class TennisGameTest
    {
        public TennisGame TennisGame;

        [SetUp]
        public void A00_SetUp()
        {
            TennisGame = new TennisGame();
        }

        [Test]
        public void A01_TennisGame_ShowResult_LoveAll()
        {
            var expected = "Love All";
            AssertShowResultReturn(expected);
        }

        [Test]
        [TestCase(1, "Fifteen Love")]
        [TestCase(2, "Thirty Love")]
        [TestCase(3, "Forty Love")]
        public void A02_TennisGame_ShowResult_Player1Score(int player1Score, string expected)
        {
            SetPlayer1Score(player1Score);

            AssertShowResultReturn(expected);
        }

        private void AssertShowResultReturn(string expected)
        {
            var result = TennisGame.ShowResult();
            result.Should().Be(expected);
        }

        private void SetPlayer1Score(int player1Score)
        {
            for (var i = 0; i < player1Score; i++)
            {
                TennisGame.Player1Score();
            }
        }
    }
}