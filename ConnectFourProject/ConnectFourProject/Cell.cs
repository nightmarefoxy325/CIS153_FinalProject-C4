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
    internal class Cell
    {
        int row;
        int col;
        Button btn;
        int status; //0 = Empty, 1 = Player 1, 2 = Player 2/Robot, 3 = Show Preview, 4 = Clear Preview
        public Cell()
        {
            status = 0; //Default to empty
        }
        public Cell(int r, int c, Button button)
        {
            row = r;
            col = c;
            btn = button;
            status = 0; //Default to empty
        }
        public int getRow()
        {
            return row;
        }
        public int getCol()
        {
            return col;
        }
        public Button getButton()
        {
            return btn;
        }
        public int getStatus()
        {
            return status;
        }
        public void setStatus(int s)
        {
            status = s;
        }

        //setters
        public void setRow(int r)
        {
            row = r;
        }

        public void setCol(int c)
        {
            col = c;
        }

        public void setBtn(Button b)
        {
            btn = b;
        }
    }
}
