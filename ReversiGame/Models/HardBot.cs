using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversiGame.Models
{
    public class HardBot : IBot
    {
        private Board board;
        private char player;
        public HardBot(Board board, char player)
        {
            this.board = board;
            this.player = player;
        }
        public string ChooseMove()
        {
            Thread.Sleep(3000);

            
            
            List<string> moves = new List<string>();
            for (int i = 0; i < Board.Size; i++)
            {
                for (int j = 0; j < Board.Size; j++)
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

            // We test all possible moves and calculate the number of points
            int maxPoints = 0;
            string coords = "";
            for (int i = 0; i < moves.Count; i++) 
            {
                // copy grid
                Board copyBoard = new Board(board);
                int col = moves[i][0] - 'A';
                int row = moves[i][1] - '1';
                copyBoard.MakeMove(row,col,player);
                int res = copyBoard.GameScore(player);
                if (res > maxPoints)
                {
                    maxPoints = res;
                    coords = moves[i];
                }
            }

            return "move " + coords;
        }
    }
}
