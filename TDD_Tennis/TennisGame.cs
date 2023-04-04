namespace TDD_Tennis
{
    public class TennisGame
    {
        private int _player1Score;

        public void Player1Score()
        {
            _player1Score++;
        }

        public string ShowResult()
        {
            if (_player1Score > 0)
            {
                return "Fifteen Love";
            }
            return "Love All";
        }
    }
}