using Microsoft.VisualBasic.Devices;
using System.ComponentModel;

namespace TicTacToe
{
    public partial class TicTacToe : Form
    {
        bool turn = true;// true = x false = o
        int turnCount = 0;

        public TicTacToe()
        {
            InitializeComponent();
        }

        private void displayTurn_Click(object sender, EventArgs e)
        {

        }

        private void playerscore2_Click(object sender, EventArgs e)
        {

        }

        private void playerscore1_Click(object sender, EventArgs e)
        {

        }
        private void button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";

            turn = !turn;
            b.Enabled = false;

            checkForWinner();
        }

        private void checkForWinner()
        {
            //horizontal checks for winner
            bool isWinner = false;
            if ((a1.Text == a2.Text) && (a2.Text == a3.Text)&&(!a1.Enabled))
                isWinner = true;

           else if ((b1.Text == b2.Text) && (b2.Text == b3.Text) && (!b1.Enabled))
                isWinner = true;

           else if ((c1.Text == c2.Text) && (c2.Text == c3.Text) && (!c1.Enabled))
                isWinner = true;

            if (isWinner)
            {
                disableButtons();
                string winner = "";
                if (turn)
                    winner = "O";
                else
                    winner = "X";
                MessageBox.Show(winner + " vann!");
            }
        }
        private void disableButtons()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
            catch { }
        }
    }  
}