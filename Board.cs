namespace TicTacToe {
    public class Board {
        public readonly char playerSign;
        public readonly char opponentSign;
        public bool IsPlayerTurn = true;
        public bool IsGameOver = false;
        public int Winner = 0;

        public List<(int, int)> _playerPoints = new List<(int, int)>();
        public List<(int, int)> _opponentPoints = new List<(int, int)>();

        public List<(int, int)[]> _winLines = new  List<(int, int)[]> {
            new [] {  (0, 0),  (0, 1),  (0, 2) },
            new [] {  (1, 0),  (1, 1),  (1, 2) },
            new [] {  (2, 0),  (2, 1),  (2, 2) },
            new [] {  (0, 0),  (1, 0),  (2, 0) },
            new [] {  (0, 1),  (1, 1),  (2, 1) },
            new [] {  (0, 2),  (1, 2),  (2, 2) },
            new [] {  (0, 0),  (1, 1),  (2, 2) },
            new [] {  (0, 2),  (1, 1),  (2, 0) },
        };

        private Point[] pola = {
            new (0, 2), new (1, 2), new (2, 2),
            new (0, 1), new (1, 1), new (2, 1),
            new (0, 0), new (1, 0), new (2, 0)
        };

        public Board(char sign) {
            switch(sign) {
                case 'X': {
                    playerSign = sign;
                    opponentSign = 'O';
                    break;
                }
                case 'O': {
                    playerSign = sign;
                    opponentSign = 'X';
                    break;
                }
            }
        }

        public void Put (int xDim, int yDim) {
            if (IsGameOver) return;
            
            foreach (var pole in pola) {
                if (pole.xDim == xDim && pole.yDim == yDim) {
                    if (IsPlayerTurn) {
                        pole.setSign(playerSign);
                        IsPlayerTurn = false;
                        _playerPoints.Add((pole.xDim, pole.yDim));
                        CheckWinner();
                    }
                    else {
                        pole.setSign(opponentSign);
                        IsPlayerTurn = true;
                        _opponentPoints.Add((pole.xDim, pole.yDim));
                        CheckWinner();
                    }
                }
            }
        }

        public void CheckWinner() {
            foreach (var winningSeq in _winLines) {
                if (_playerPoints.Contains(winningSeq[0]) && 
                    _playerPoints.Contains(winningSeq[1]) &&
                    _playerPoints.Contains(winningSeq[2])) {
                    
                    IsGameOver = true;
                    Winner = 1;
                    break;
                }

                if (_opponentPoints.Contains(winningSeq[0]) && 
                    _opponentPoints.Contains(winningSeq[1]) &&
                    _opponentPoints.Contains(winningSeq[2])) {
                    
                    IsGameOver = true;
                    Winner = 0;
                    break;
                }
            }
        }

        public void Show() {
            Console.WriteLine("");
            var poprzedni = 0;

            foreach (Point pole in pola) {
                if (poprzedni != pole.yDim) {
                    Console.WriteLine("");
                }
                Console.Write($"[{pole.sign}] ");
                poprzedni = pole.yDim;
            }
            Console.WriteLine("");
        }
    }
}