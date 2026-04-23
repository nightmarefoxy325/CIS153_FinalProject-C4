using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.ComponentModel;
using System.Data;
namespace ConnectFourProject
{
    internal class Board
    {
        public const int rows = 7;
        public const int columns = 7;
        Cell[,] gameboard = new Cell[rows, columns];

        bool isgameover;
        bool playerturn;
        int playercolor;
        int aiturn;

        public int getrows()
        {
            return rows;
        }
        public int getcols()
        {
            return columns;
        }
        public Cell getcell(int r, int c)
        {
            return gameboard[r, c];
        }
        public Cell[,] getboard()
        {
            return gameboard;
        }
        public void setgameboard(Cell cell)
        {
            gameboard[cell.getRow(), cell.getCol()] = cell;
        }
        public bool DropPiece(int col, int playerNum)
        {
            for (int r = rows - 1; r >= 0; r--)
            {
                ClearStatusAndColor(col);
                if (gameboard[r, col].getStatus() == 0)
                {
                    gameboard[r, col].setStatus(playerNum);

                    if (playerNum == 1)
                    {
                        if (gameboard[r, col].getButton().BackColor == Color.Red || gameboard[r, col].getButton().BackColor == Color.Yellow)
                        {
                            r = r - 1;
                            gameboard[r, col].getButton().BackColor = Color.Red;
                        }
                        if (gameboard[r, col].getButton().BackColor != Color.Red && gameboard[r, col].getButton().BackColor != Color.Yellow)
                        {
                            gameboard[r, col].getButton().BackColor = Color.Red;
                        }
                    }
                    else
                    {
                        if (gameboard[r, col].getButton().BackColor == Color.Red || gameboard[r, col].getButton().BackColor == Color.Yellow)
                        {
                            r = r - 1;
                            gameboard[r, col].getButton().BackColor = Color.Yellow;
                        }
                        if (gameboard[r, col].getButton().BackColor != Color.Red && gameboard[r, col].getButton().BackColor != Color.Yellow)
                        {
                            gameboard[r, col].getButton().BackColor = Color.Yellow;
                        }
                    }
                    return true;
                }
            }
            return false;
        }

        public bool ShowPreview(int col, int playerNum)
        {
            for (int r = rows - 1; r >= 0; r--)
            {
                if (gameboard[r, col].getStatus() == 1 || gameboard[r, col].getStatus() == 2)
                {
                    continue;
                }
                else if (gameboard[r, col].getStatus() == 0)
                {
                    gameboard[r, col].setStatus(3);

                    if (gameboard[r, col].getStatus() == 3 && playerNum == 1)
                    {
                        gameboard[r, col].getButton().BackColor = Color.Red;
                    }
                    else
                    {
                        gameboard[r, col].getButton().BackColor = Color.Yellow;
                    }
                    return true;
                }
            }
            return false;
        }

        public void ClearStatusAndColor(int col)
        {
            for (int r = 0; r < rows; r++)
            {
                if (gameboard[r, col].getStatus() == 1 || gameboard[r, col].getStatus() == 2)
                {
                    continue;
                }
                else if (gameboard[r, col].getStatus() == 3)
                {
                    gameboard[r, col].setStatus(4);

                    if (gameboard[r, col].getStatus() == 4)
                    {
                        gameboard[r, col].setStatus(0);
                    }
                    if (gameboard[r, col].getStatus() == 0)
                    {
                        gameboard[r, col].getButton().BackColor = Color.White;
                    }
                }
            }
        }

        public int CheckForWin()
        {
            //1. Check Horizontal (Rows)
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns - 3; c++)
                {
                    if (gameboard[r, c] == null)
                    {
                        continue;
                    }
                    int s = gameboard[r, c].getStatus();
                    if (s != 0 && s == gameboard[r, c + 1].getStatus() &&
                        s == gameboard[r, c + 2].getStatus() &&
                        s == gameboard[r, c + 3].getStatus())
                        return s; //Returns 1 or 2 depending on who won
                }
            }

            //2. Check Vertical (Columns)
            for (int r = 0; r < rows - 3; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    if (gameboard[r, c] == null)
                    {
                        continue;
                    }
                    int s = gameboard[r, c].getStatus();
                    if (s != 0 && s == gameboard[r + 1, c].getStatus() &&
                        s == gameboard[r + 2, c].getStatus() &&
                        s == gameboard[r + 3, c].getStatus())
                        return s;
                }
            }

            //3. Check Diagonal (Down-Right)
            for (int r = 0; r < rows - 3; r++)
            {
                for (int c = 0; c < columns - 3; c++)
                {
                    if (gameboard[r, c] == null)
                    {
                        continue;
                    }
                    int s = gameboard[r, c].getStatus();
                    if (s != 0 && s == gameboard[r + 1, c + 1].getStatus() &&
                        s == gameboard[r + 2, c + 2].getStatus() &&
                        s == gameboard[r + 3, c + 3].getStatus())
                        return s;
                }
            }

            //4. Check Diagonal (Up-Right)
            for (int r = 3; r < rows; r++)
            {
                for (int c = 0; c < columns - 3; c++)
                {
                    if (gameboard[r, c] == null)
                    {
                        continue;
                    }
                    int s = gameboard[r, c].getStatus();
                    if (s != 0 && s == gameboard[r - 1, c + 1].getStatus() &&
                        s == gameboard[r - 2, c + 2].getStatus() &&
                        s == gameboard[r - 3, c + 3].getStatus())
                        return s;
                }
            }

            return 0; //No winner yet
        }
        public Board()
        {
            //constructor to call in main forms
        }
    }
}
