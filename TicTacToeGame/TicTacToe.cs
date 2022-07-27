namespace TicTacToeGame;

public class TicTacToe {
    private bool IsFirstPlayer = true;
    private string[,] Board = new string[3, 3];
    public bool IsBoardEmpty = true;
    private const string firstPlayerToken = "X";
    private const string secondPlayerToken = "0";

    public void Move(Position position) {
        if (GetPosition(position) != null) {
            throw new ArgumentException("This field is already taken");
        }
        Board[position.x, position.y] = GetCurrentPLayerToken();
        IsFirstPlayer = !IsFirstPlayer;
    }

    public string GetCurrentPLayerToken() {
        return IsFirstPlayer ? firstPlayerToken : secondPlayerToken;
    }

    public object GetPosition(Position movement) {
        return Board[movement.x, movement.y];
    }
}