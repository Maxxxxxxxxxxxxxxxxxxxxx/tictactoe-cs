namespace TicTacToe;

class Program {
	static void Main() {
		Console.WriteLine("Tiktaktoe\n************\n\n1: Krzyzyk\n2:Kolko");
		int opcja = Util.ReadLineParseDigit();
		
		// Console.WriteLine("Tryb numpad [ TicTacToe.Tests / N ]: ");
		// char tryb = Console.ReadLine().ToCharArray()[0];
		
		Game TicTacToe = new Game(opcja);
		Console.Clear();
		
		TicTacToe.Start();
	}
}