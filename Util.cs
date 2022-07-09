namespace TicTacToe; 

public class Util {
    public static (int, int) ReadLineVectorIn() {
        string input = Console.ReadLine();
        
        // przykladowo oczekiwane inputy: "1 1", "0 2", "3 3"
        // parsuje tylko pierwszego i ostatniego chara
        (int, int) tupla = (
            Int32.Parse(input.Substring(0, 1)),
            Int32.Parse(input.Substring(input.Length - 1))
        );

        return tupla;
    }

    public static (int, int) GetKeyParseVector() {
        (int, int) vector = (1, 1);
        ConsoleKeyInfo key = Console.ReadKey();

        switch (key.KeyChar) {
            case '1': {
                vector = (0, 0);
                break;
            }
            case '2': {
                vector = (1, 0);
                break;
            }
            case '3': {
                vector = (2, 0);
                break;
            }
            case '4': {
                vector = (0, 1);
                break;
            }
            case '5': {
                vector = (1, 1);
                break;
            }
            case '6': {
                vector = (2, 1);
                break;
            }
            case '7': {
                vector = (0, 2);
                break;
            }
            case '8': {
                vector = (1, 2);
                break;
            }
            case '9': {
                vector = (2, 2);
                break;
            }
        }
        // Console.WriteLine($"{vector.Item1}, {vector.Item2}");

        return vector;
    }
    
    public static int ReadLineParseDigit() {
        string input = Console.ReadLine();
        return Int32.Parse(input.Substring(0,1));
    }
}