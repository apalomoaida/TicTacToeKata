namespace TicTacToeGame;

public class Position {
    public Position(int x, int y) {
        this.x = x;
        this.y = y;
    }

    public int x { get; private set; }
    public int y { get; private set; }
}

public class TicTacToe {
    private string[,] Board = new string[3, 3];
    public bool IsBoardEmpty = true;

    public void Move(Position position) {
        Board[position.x, position.y] = "X";
    }

    public object GetPosition(Position movement) {
        return Board[movement.x, movement.y];
    }
}