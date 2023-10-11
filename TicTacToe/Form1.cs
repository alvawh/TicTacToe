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
        {  //game starts with x and then switches to o
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

            // vertical checks for winner
            if ((a1.Text == b1.Text) && (b1.Text == c1.Text) && (!a1.Enabled))
                isWinner = true;

            else if ((a2.Text == b2.Text) && (b2.Text == c2.Text) && (!a2.Enabled))
                isWinner = true;

            else if ((a3.Text == b3.Text) && (b3.Text == c3.Text) && (!a3.Enabled))
                isWinner = true;
            // diagonal checks for winner
            if ((a1.Text == b2.Text) && (b2.Text == c3.Text) && (!a1.Enabled))
                isWinner = true;

            else if ((c1.Text == b2.Text) && (b2.Text == a3.Text) && (!c1.Enabled))
                isWinner = true;

            //if there is a winner show message box
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
        private void disableButtons()//disable buttons after the game is over
        {
            try
            { 
                foreach (Control c in Controls)
                {
                   
                    Button b = c as Button;

                    
                    if (b != null)
                    {
                        
                        b.Enabled = false;
                    }
                }
            }
            catch 
            {
    
            }
        }
    }  
}