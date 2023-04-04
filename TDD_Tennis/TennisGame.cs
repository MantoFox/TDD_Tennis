using System.Collections.Generic;

namespace TDD_Tennis
{
    public class TennisGame
    {
        private int _player1Score;

        private Dictionary<int, string> _scoreDictionary = new Dictionary<int, string>
        {
            {1, "Fifteen"},
            {2, "Thirty"}
        };

        public void Player1Score()
        {
            _player1Score++;
        }

        public string ShowResult()
        {
            if (_player1Score > 0)
            {
                return $"{_scoreDictionary[_player1Score]} Love";
            }
            return "Love All";
        }
    }
}