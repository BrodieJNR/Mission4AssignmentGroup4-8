using Mission4AssignmentGroup4_8;
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Tic Tac Toe!");
        Console.WriteLine("Players will take turns choosing the spots using 0-8!");

        string[] board = ["0", "1", "2", "3", "4", "5", "6", "7", "8"];
        int currentPlayer = 1;
        string win = "";

        while (win == "")
        {
            Console.Clear();
            Supporting.PrintBoard(board);

            string symbol = currentPlayer == 1 ? "X" : "O";

            Console.WriteLine($"Player {currentPlayer} choose a position 0-8: ");
            string choice = Console.ReadLine();

            if (!int.TryParse(choice, out int position) || position < 0 || position > 8)
            {
                Console.WriteLine("Not an option please choose another spot");
                Console.ReadLine();
                continue;
            }

            if (board[position] == "X" || board[position] == "O")
            {
                Console.WriteLine("That spot is taken. Press Enter then choose again.");
                Console.ReadLine();
                continue;
            }

            board[position] = symbol;
            
            win = Supporting.CheckWinner(board);
            
            if (win == "")
            {
                bool boardFull = true;
                foreach (string space in board)
                {
                    if (space != "X" && space != "O")
                    {
                        boardFull = false;
                        break;
                    }
                }

                if (boardFull)
                {
                    win = "Draw";
                }
            }

            if (win == "")
            {
                currentPlayer = currentPlayer == 1 ? 2 : 1;
            }
        }

        Console.Clear();
        Supporting.PrintBoard(board);

        if (win == "Draw")
        {
            Console.WriteLine("It's a draw!");
        }
        else
        {
            int winnerNumber = win == "X" ? 1 : 2;
            Console.WriteLine($"Player {winnerNumber} ({win}) wins!");
        }

        Console.WriteLine("Thanks for playing!");
        Console.ReadLine();
    }
}
    
    


