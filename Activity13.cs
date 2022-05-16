using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity13
{
    public partial class Activity13 : Form
    {
        

        // declare the game board array
        int[,] gameBoard = new int[3, 3];

        // variable for winner
        string winner = "";

        public Activity13()
        {
            InitializeComponent();
        }

        private void btn_newGame_Click_1(object sender, EventArgs e)
        {
            // random number generator
            Random rnd = new Random();

            // loop through the game board array
            for (int i = 0; i < 3; i++)  
            {
                for (int j = 0; j < 3; j++)
                {
                    // generate a random number between 0 and 1
                    int rndNumber = rnd.Next(0, 2);

                    // store the random number in the game board array
                    gameBoard[i, j] = rndNumber;
                }
            }

            // display the game board in the rich text boxes as O or X
            if (gameBoard[0, 0] == 0)
            {
                box1.Text = "O";
            }
            else
            {
                box1.Text = "X";
            }

            if (gameBoard[0, 1] == 0)
            {
                box2.Text = "O";
            }
            else
            {
                box2.Text = "X";
            }

            if (gameBoard[0, 2] == 0)
            {
                box3.Text = "O";
            }
            else
            {
                box3.Text = "X";
            }

            if (gameBoard[1, 0] == 0)
            {
                box4.Text = "O";
            }
            else
            {
                box4.Text = "X";
            }

            if (gameBoard[1, 1] == 0)
            {
                box5.Text = "O";
            }
            else
            {
                box5.Text = "X";
            }

            if (gameBoard[1, 2] == 0)
            {
                box6.Text = "O";
            }
            else
            {
                box6.Text = "X";
            }

            if (gameBoard[2, 0] == 0)
            {
                box7.Text = "O";
            }
            else
            {
                box7.Text = "X";
            }

            if (gameBoard[2, 1] == 0)
            {
                box8.Text = "O";
            }
            else
            {
                box8.Text = "X";
            }

            if (gameBoard[2, 2] == 0)
            {
                box9.Text = "O";
            }
            else
            {
                box9.Text = "X";
            }


            // check for a winner
            winner = CheckForWinner();

            
            if (winner == "")
            {
                winnerBox.Text = "It is a draw!";
            }
            else
            {
                winnerBox.Text = winner + " Wins!";
            }

        }

        private string CheckForWinner()
        {
            // declare the winner
            string winner = "";


            // check to see if O won
            if (gameBoard[0, 0] == 0 && gameBoard[0, 1] == 0 && gameBoard[0, 2] == 0)
            {
                winner = "O";
            }
            else if (gameBoard[1, 0] == 0 && gameBoard[1, 1] == 0 && gameBoard[1, 2] == 0)
            {
                winner = "O";
            }
            else if (gameBoard[2, 0] == 0 && gameBoard[2, 1] == 0 && gameBoard[2, 2] == 0)
            {
                winner = "O";
            }
            else if (gameBoard[0, 0] == 0 && gameBoard[1, 0] == 0 && gameBoard[2, 0] == 0)
            {
                winner = "O";
            }
            else if (gameBoard[0, 1] == 0 && gameBoard[1, 1] == 0 && gameBoard[2, 1] == 0)
            {
                winner = "O";
            }
            else if (gameBoard[0, 2] == 0 && gameBoard[1, 2] == 0 && gameBoard[2, 2] == 0)
            {
                winner = "O";
            }
            else if (gameBoard[0, 0] == 0 && gameBoard[1, 1] == 0 && gameBoard[2, 2] == 0)
            {
                winner = "O";
            }
            else if (gameBoard[0, 2] == 0 && gameBoard[1, 1] == 0 && gameBoard[2, 0] == 0)
            {
                winner = "O";
            }

            // check to see if X won
            if (gameBoard[0, 0] == 1 && gameBoard[0, 1] == 1 && gameBoard[0, 2] == 1)
            {
                winner = "X";
            }
            else if (gameBoard[1, 0] == 1 && gameBoard[1, 1] == 1 && gameBoard[1, 2] == 1)
            {
                winner = "X";
            }
            else if (gameBoard[2, 0] == 1 && gameBoard[2, 1] == 1 && gameBoard[2, 2] == 1)
            {
                winner = "X";
            }
            else if (gameBoard[0, 0] == 1 && gameBoard[1, 0] == 1 && gameBoard[2, 0] == 1)
            {
                winner = "X";
            }
            else if (gameBoard[0, 1] == 1 && gameBoard[1, 1] == 1 && gameBoard[2, 1] == 1)
            {
                winner = "X";
            }
            else if (gameBoard[0, 2] == 1 && gameBoard[1, 2] == 1 && gameBoard[2, 2] == 1)
            {
                winner = "X";
            }
            else if (gameBoard[0, 0] == 1 && gameBoard[1, 1] == 1 && gameBoard[2, 2] == 1)
            {
                winner = "X";
            }
            else if (gameBoard[0, 2] == 1 && gameBoard[1, 1] == 1 && gameBoard[2, 0] == 1)
            {
                winner = "X";
            }
            

            // return the winner
            return winner;
        }
        private void btn_Exit_Click_1(object sender, EventArgs e)
        {
            // close app
            this.Close();
        }

        




        

        private void box5_TextChanged(object sender, EventArgs e)
        {

        }
    }


}
