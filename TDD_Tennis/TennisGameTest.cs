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
        [TestCase(1, 0, "Fifteen Love")]
        [TestCase(2, 0, "Thirty Love")]
        [TestCase(3, 0, "Forty Love")]
        public void A02_TennisGame_ShowResult_Player1Score(int player1Score, int player2Score, string expected)
        {
            SetPlayer1Score(player1Score);
            SetPlayer2Score(player2Score);

            AssertShowResultReturn(expected);
        }

        [Test]
        [TestCase(0, 1, "Love Fifteen")]
        public void A03_TennisGame_ShowResult_Player2Score(int player1Score, int player2Score, string expected)
        {
            SetPlayer1Score(player1Score);
            SetPlayer2Score(player2Score);

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

        private void SetPlayer2Score(int player2Score)
        {
            for (var i = 0; i < player2Score; i++)
            {
                TennisGame.Player2Score();
            }
        }
    }
}