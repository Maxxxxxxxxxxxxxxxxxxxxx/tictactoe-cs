namespace TicTacToe;

public class Point {
    public int xDim;
    public int yDim;
    public char sign = ' ';
	public bool _hasSign;

    public Point(int x, int y) {
        xDim = x;
        yDim = y;
    }

    public void setSign(char newSign) {
        sign = newSign;
		_hasSign = true;
    }
}

