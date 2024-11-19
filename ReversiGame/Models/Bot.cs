﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversiGame.Models
{
    public class Bot : IBot
    {
        private Board board;
        private char player;
        public Bot(Board board, char player) 
        { 
            this.board = board;
            this.player = player;
        }
        public string ChooseMove()
        {
            Random rand = new Random();
            int v = rand.Next(3000, 5000);
            Thread.Sleep(v); // random delay

            List<string> moves = new List<string>();
            for (int i = 0; i < Board.Size; i++)
            {
                for (int j = 0;j < Board.Size; j++)
                {
                    if (board.IsValidMove(i, j, player))
                    {
                        string m = "";
                        m += (char)(j + 'A');
                        m += (char)(i + '1');
                        moves.Add(m);
                    }
                }
            }
            if (moves.Count == 0) { return "skip"; }

            Random random = new Random();
            int num = random.Next(0, moves.Count());
            return "move " + moves[num];
        }
    }
}
