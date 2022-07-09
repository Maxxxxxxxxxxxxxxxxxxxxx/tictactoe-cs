namespace TicTacToe; 

public class Game {
    private int turnNumber = 0;
    private Board board;
    
    public Game (int option) {
        board = (option == 1) 
            ? new Board('X') 
            : new Board('O');
    }

    public void Start() {
        while (!board.IsGameOver) {
            Console.Clear();
            board.CheckWinner();
            Console.WriteLine(board.IsGameOver);
            Turn();
        }
        
        var winnerName = board.Winner == 1 ? board.playerSign : board.opponentSign;
        board.Show();
        Console.WriteLine($"\nWygrywa gracz {winnerName}");
        }

    public void Turn () {
        board.Show();
        
        if (board.IsPlayerTurn) Console.WriteLine($"Gracz: {board.playerSign}"); 
        else Console.WriteLine($"Gracz: {board.opponentSign}");
        
        (int, int) vector = Util.GetKeyParseVector();

        turnNumber++;
        
        board.Put(vector.Item1, vector.Item2);
    }
}