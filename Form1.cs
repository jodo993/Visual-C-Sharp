using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeSimulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Display the result of the array into the game board
        //@param board - holds the results of the 2D array
        private void DisplayPick(int[,] board)
        {
            // Label will display O if = 0
            // Label will display X if = 1
            if (board[0, 0] == 0)
                labelOne.Text = "O";
            else
                labelOne.Text = "X";
            if (board[0, 1] == 0)
                labelTwo.Text = "O";
            else
                labelTwo.Text = "X";
            if (board[0, 2] == 0)
                labelThree.Text = "O";
            else
                labelThree.Text = "X";
            if (board[1, 0] == 0)
                labelFour.Text = "O";
            else
                labelFour.Text = "X";
            if (board[1, 1] == 0)
                labelFive.Text = "O";
            else
                labelFive.Text = "X";
            if (board[1, 2] == 0)
                labelSix.Text = "O";
            else
                labelSix.Text = "X";
            if (board[2, 0] == 0)
                labelSeven.Text = "O";
            else
                labelSeven.Text = "X";
            if (board[2, 1] == 0)
                labelEight.Text = "O";
            else
                labelEight.Text = "X";
            if (board[2, 2] == 0)
                labelNine.Text = "O";
            else
                labelNine.Text = "X";
        }

        // Check the winning combinations horizontally, vertically, and diagonally
        //@param board - holds the result of the 2D array
        private void CheckingWinner(int[,] board)
        {
            // Player with more winning combos will get more points and win the game
            int playerYPoints = 0;              // Player Y points in case more winning combo shows up
            int playerXPoints = 0;              // Player X points in case more winning combo shows up

            // Checks the game board for winning horizontal combinations
            if (board[0, 0] == 0 && board[0, 0] == board[0, 1] && board[0, 0] == board[0, 2])
                playerYPoints = playerYPoints + 1;
            else if (board[0, 0] == 1 && board[0, 0] == board[0, 1] && board[0, 0] == board[0, 2])
                playerXPoints = playerXPoints + 1;

            if (board[1, 0] == 0 && board[1, 0] == board[1, 1] && board[1, 0] == board[1, 2])
                playerYPoints = playerYPoints + 1;
            else if (board[1, 0] == 1 && board[1, 0] == board[1, 1] && board[1, 0] == board[1, 2])
                playerXPoints = playerXPoints + 1;

            if (board[2, 0] == 0 && board[2, 0] == board[2, 1] && board[2, 0] == board[2, 2])
                playerYPoints = playerYPoints + 1;
            else if (board[2, 0] == 1 && board[2, 0] == board[2, 1] && board[2, 0] == board[2, 2])
                playerXPoints = playerXPoints + 1;

            // Checks the game board for winning vertical combinations
            if (board[0, 0] == 0 && board[0, 0] == board[1, 0] && board[0, 0] == board[2, 0])
                playerYPoints = playerYPoints + 1;
            else if (board[0, 0] == 1 && board[0, 0] == board[1, 0] && board[0, 0] == board[2, 0])
                playerXPoints = playerXPoints + 1;

            if (board[0, 1] == 0 && board[0, 1] == board[1, 1] && board[0, 1] == board[2, 1])
                playerYPoints = playerYPoints + 1;
            else if (board[0, 1] == 1 && board[0, 1] == board[1, 1] && board[0, 1] == board[2, 1])
                playerXPoints = playerXPoints + 1;

            if (board[0, 2] == 0 && board[0, 2] == board[1, 2] && board[0, 2] == board[2, 2])
                playerYPoints = playerYPoints + 1;
            else if (board[0, 2] == 1 && board[0, 2] == board[1, 2] && board[0, 2] == board[2, 2])
                playerXPoints = playerXPoints + 1;

            // Checks the game board for winning diagonal combinations
            if (board[0, 0] == 0 && board[0, 0] == board[1, 1] && board[0, 0] == board[2, 2])
                playerYPoints = playerYPoints + 1;
            else if (board[0, 0] == 1 && board[0, 0] == board[1, 1] && board[0, 0] == board[2, 2])
                playerXPoints = playerXPoints + 1;

            if (board[0, 2] == 0 && board[0, 2] == board[1, 1] && board[0, 2] == board[2, 0])
                playerYPoints = playerYPoints + 1;
            else if (board[0, 2] == 1 && board[0, 2] == board[1, 1] && board[0, 2] == board[2, 0])
                playerXPoints = playerXPoints + 1;

            // Checks to see which player got more points
            if (playerYPoints > playerXPoints)
                resultLabel.Text = "Player Y Wins!";
            else if (playerXPoints > playerYPoints)
                resultLabel.Text = "Player X Wins!";
            else
                resultLabel.Text = "Tie Game!.";
        }

        // Main method
        private void newGameButton_Click(object sender, EventArgs e)
        {
            const int ROWS = 3;                     // Numbers of rows in the array
            const int COLS = 3;                     // Numbers of columns in the array
            int[,] board = new int[ROWS, COLS];     // How big the 2D array is

            // Random number picker from 0-1
            Random pick = new Random();

            // Nested for loop to determine the number 0(O) or 1(X) to show on game for
            // Fill the 2D array
            for (int row = 0; row < ROWS; row++)
            {
                for (int col = 0; col < COLS; col++)
                {
                    board[row, col] = pick.Next(0, 2);
                }
            }

            DisplayPick(board);               // Send array result to show X or O on the game board
            CheckingWinner(board);            // Send array to check for winning combination and display winner
        }

        // Closes the program
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
