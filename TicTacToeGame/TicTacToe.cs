namespace TicTacToeGame;

public class TicTacToe {
    private bool IsFirstPlayer = true;
    private string[,] Board = new string[3, 3];
    public bool IsBoardEmpty = true;
    public const string FirstPlayerToken = "X";
    public const string SecondPlayerToken = "0";

    public void Move(Position position) {
        Board[position.x, position.y] = GetCurrentPLayerToken();
        IsFirstPlayer = !IsFirstPlayer;
    }

    private string GetCurrentPLayerToken() {
        return IsFirstPlayer ? FirstPlayerToken : SecondPlayerToken;
    }

    public object GetPosition(Position movement) {
        return Board[movement.x, movement.y];
    }
}