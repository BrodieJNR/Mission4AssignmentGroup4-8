namespace Mission4AssignmentGroup4_8;

public class Supporting  // or whatever name you choose
{
    public static void PrintBoard(string[] board)
    {
        Console.WriteLine(board[0] + " | " + board[1] + " | " + board[2]);
        Console.WriteLine("---------");
        Console.WriteLine(board[3] + " | " + board[4] + " | " + board[5]);
        Console.WriteLine("---------");
        Console.WriteLine(board[6] + " | " + board[7] + " | " + board[8]);
    }
    public static string CheckWinner(string[] board)
    {
        // Check rows
        if (board[0] == board[1] && board[1] == board[2] && board[0] != "0" && board[0] != "1" && board[0] != "2")
            return board[0];
    
        if (board[3] == board[4] && board[4] == board[5] && board[3] != "3" && board[3] != "4" && board[3] != "5")
            return board[3];
    
        if (board[6] == board[7] && board[7] == board[8] && board[6] != "6" && board[6] != "7" && board[6] != "8")
            return board[6];
    
        // Check columns
        if (board[0] == board[3] && board[3] == board[6] && board[0] != "0" && board[0] != "3" && board[0] != "6")
            return board[0];
    
        if (board[1] == board[4] && board[4] == board[7] && board[1] != "1" && board[1] != "4" && board[1] != "7")
            return board[1];
    
        if (board[2] == board[5] && board[5] == board[8] && board[2] != "2" && board[2] != "5" && board[2] != "8")
            return board[2];
    
        // Check diagonals
        if (board[0] == board[4] && board[4] == board[8] && board[0] != "0" && board[0] != "4" && board[0] != "8")
            return board[0];
    
        if (board[2] == board[4] && board[4] == board[6] && board[2] != "2" && board[2] != "4" && board[2] != "6")
            return board[2];
    
        return "";  // No winner
    }
}
    
    