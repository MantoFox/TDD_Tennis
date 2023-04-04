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
        public void A01_TennisGame_ShowResult()
        {
            var result = TennisGame.ShowResult();
            result.Should().Be("Love All");
        }
    }
}