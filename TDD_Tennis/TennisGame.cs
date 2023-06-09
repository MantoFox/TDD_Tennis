﻿using System;
using System.Collections.Generic;

namespace TDD_Tennis
{
    public class TennisGame
    {
        private readonly string _player1Name;

        private readonly string _player2Name;

        private readonly Dictionary<int, string> _scoreDictionary = new Dictionary<int, string>
        {
            {0, "Love"},
            {1, "Fifteen"},
            {2, "Thirty"},
            {3, "Forty"}
        };

        private int _player1Score;
        private int _player2Score;

        public TennisGame(string player1Name, string player2Name)
        {
            _player1Name = player1Name;
            _player2Name = player2Name;
        }

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
            var result = _player1Score - _player2Score;
            if ((_player1Score > 3 || _player2Score > 3) && (Math.Abs(result) >= 1))
            {
                var advName = result > 0 ? _player1Name : _player2Name;
                return Math.Abs(result) == 1 ? $"{advName} Adv" : $"{advName} Win";
            }

            if (_player1Score == _player2Score && _player1Score > 2)
            {
                return "Deuce";
            }

            if (_player1Score == _player2Score)
            {
                return $"{_scoreDictionary[_player1Score]} All";
            }

            if (_player1Score > 0 || _player2Score > 0)
            {
                return $"{_scoreDictionary[_player1Score]} {_scoreDictionary[_player2Score]}";
            }

            return "Love All";
        }
    }
}