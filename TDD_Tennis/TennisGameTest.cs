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
        public void A02_TennisGame_ShowResult_FifteenLove()
        {
            TennisGame.Player1Score();
            var expected = "Fifteen Love";
            AssertShowResultReturn(expected);
        }

        [Test]
        public void A03_TennisGame_ShowResult_ThirtyLove()
        {
            TennisGame.Player1Score();
            TennisGame.Player1Score();
            var expected = "Thirty Love";
            AssertShowResultReturn(expected);
        }

        private void AssertShowResultReturn(string expected)
        {
            var result = TennisGame.ShowResult();
            result.Should().Be(expected);
        }
    }
}