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
    public partial class VsPlayer : Form
    {
        bool player1Turn = true;
        bool player2Turn = false;
        Board getboard;
        public VsPlayer()
        {
            InitializeComponent();
            getboard = new Board();
            setupboard();
            //getboard.getcell(0, 5).getButton().BackColor = Color.Green;
            //the above line doesnt matter, I included this so you two can know how to pull a specific point, 
            //each button is individually named so in the instance you need to know a specific point check names

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
                button.MouseEnter += CellShowPreview;
                button.MouseLeave += CellClearPreview;

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
        private void VsPlayer_Load(object sender, EventArgs e)
        {

        }

        public void revertButtonColor(object sender, EventArgs e)
        {
            foreach (var button in this.Controls.OfType<Button>())
            {
                button.BackColor = Color.White;
            }
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

        private void OnCellClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            HandleMove(btn);
        }

        private void CellShowPreview(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            movePreview(btn);
        }

        private void CellClearPreview(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            clearPreview(btn);
        }

        private void movePreview(Button clickedButton)
        {
            int lastUnderscore = clickedButton.Name.LastIndexOf('_');
            int col = Int32.Parse(clickedButton.Name.Substring(lastUnderscore + 1));

            bool ShowPreview = true;

            if (ShowPreview == true && player1Turn == true)
            {
                getboard.ShowPreview(col, 1);
                //ShowPreview = false;
            }
            else
            {
                getboard.ShowPreview(col, 2);
            }
        }

        private void clearPreview(Button clickedButton)
        {
            int lastUnderscore = clickedButton.Name.LastIndexOf('_');
            int col = Int32.Parse(clickedButton.Name.Substring(lastUnderscore + 1));

            bool ClearPreview = true;

            if (ClearPreview == true)
            {
                getboard.ClearStatusAndColor(col);
            }
        }
    }
}
