using System.Collections.Generic;

namespace TDD_Tennis
{
    public class TennisGame
    {
        private readonly Dictionary<int, string> _scoreDictionary = new Dictionary<int, string>
        {
            {1, "Fifteen"},
            {2, "Thirty"},
            {3, "Forty"}
        };

        private int _player1Score;
        private int _player2Score;

        public void Player1Score()
        {
            _player1Score++;
        }

        public void Player2Score()
        {
            _player2Score++;
        }

        public string ShowResult()
        {
            if (_player1Score > 0)
            {
                return $"{_scoreDictionary[_player1Score]} Love";
            }

            if (_player2Score > 0)
            {
                return $"Love {_scoreDictionary[_player2Score]}";
            }
            return "Love All";
        }
    }
}