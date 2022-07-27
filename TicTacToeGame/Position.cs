namespace TicTacToeGame;

public class Position {
    public Position(int x, int y) {
        this.x = x;
        this.y = y;
    }

    public int x { get; private set; }
    public int y { get; private set; }
}