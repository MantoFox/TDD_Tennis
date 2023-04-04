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
            var result = TennisGame.ShowResult();
            result.Should().Be("Love All");
        }

        [Test]
        public void A02_TennisGame_ShowResult_FifteenLove()
        {
            TennisGame.Player1Score();
            var result = TennisGame.ShowResult();
            result.Should().Be("Fifteen Love");
        }
    }
}