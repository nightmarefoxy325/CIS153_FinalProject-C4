using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectFourProject
{
    public partial class VsRobot : Form
    {
        bool player1Turn = true;
        bool player2Turn = false;
        Board getboard;
        public VsRobot()
        {
            InitializeComponent();
            getboard = new Board();
            setupboard();
        }
        public void setupboard()
        {
            string name;
            char delim = '_';
            int posDelim;
            int col;
            int row;
            Cell c;
            foreach (var button in this.Controls.OfType<Button>())
            {
                button.Click += OnCellClick;
                name = button.Name;
                posDelim = name.IndexOf(delim);
                row = Int32.Parse(name.Substring(posDelim + 1, 1));
                name = name.Substring(posDelim + 2);
                posDelim = name.IndexOf(delim);
                col = Int32.Parse(name.Substring(posDelim + 1));

                c = new Cell(row, col, button);

                getboard.setgameboard(c);
                //this finds each button and stores them for get button
                //if you touch this program please let me know any changes
            }
        }
        private void OnCellClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            HandleMove(btn);
        }
        private void HandleMove(Button clickedButton)
        {
            int lastUnderscore = clickedButton.Name.LastIndexOf('_');
            int col = Int32.Parse(clickedButton.Name.Substring(lastUnderscore + 1));
            if (player1Turn == true)
            {
                bool moveWasLegal = getboard.DropPiece(col, 1);
                player1Turn = false;
                player2Turn = true;
                if (moveWasLegal)
                {
                    int winner = getboard.CheckForWin();
                    if (winner != 0)
                    {
                        MessageBox.Show("Player " + winner + " wins!");
                    }
                }
            }
            else if (player2Turn == true)
            {
                bool moveWasLegal = getboard.DropPiece(col, 2);
                player2Turn = false;
                player1Turn = true;
                if (moveWasLegal)
                {
                    int winner = getboard.CheckForWin();
                    if (winner != 0)
                    {
                        MessageBox.Show("Player " + winner + " wins!");
                    }
                }
            }
        }
        private void VsRobot_Load(object sender, EventArgs e)
        {

        }
    }
}
