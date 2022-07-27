namespace TicTacToeGame;

public class TicTacToe {
    private bool _isFirstPlayer = true;
    private readonly string?[,] _board = new string[3, 3];
    private const string FirstPlayerToken = "X";
    private const string SecondPlayerToken = "0";
    private int _movementCount;

    public bool IsBoardEmpty() {
        return _movementCount == 0;
    }

    public string Move(Position position) {
        if (GetPosition(position) != null) {
            throw new ArgumentException("This field is already taken");
        }
        _board[position.x, position.y] = GetCurrentPLayerToken();
        var message = GetStatusMessage();
        _isFirstPlayer = !_isFirstPlayer;
        return message;
    }

    private string GetStatusMessage() {
        ++_movementCount;
        if (WinByHorizontalLine() || WinByVerticalLine() || WinByDiagionalLine())
            return GetCurrentPLayerToken() + " wins";
        if (_movementCount == 9)
            return "Draw";
        return "Next movement";
    }

    public string GetCurrentPLayerToken() {
        return _isFirstPlayer ? FirstPlayerToken : SecondPlayerToken;
    }

    public string? GetPosition(Position position) {
        return _board[position.x, position.y];
    }
    private bool WinByVerticalLine() {
        return (_board[0, 0] != null && _board[0, 0] == _board[1, 0] && _board[0, 0] == _board[2, 0]) ||
               (_board[0, 1] != null && _board[0, 1] == _board[1, 1] && _board[0, 1] == _board[2, 1]) ||
               (_board[0, 2] != null && _board[0, 2] == _board[1, 2] && _board[0, 2] == _board[2, 2]);
    }

    private bool WinByDiagionalLine() {
        return (_board[0, 0] != null && _board[0, 0] == _board[1, 1] && _board[0, 0] == _board[2, 2]) ||
               (_board[0, 2] != null && _board[0, 2] == _board[1, 1] && _board[0, 2] == _board[2, 0]);
    }

    private bool WinByHorizontalLine() {
        return (_board[0, 0] != null && _board[0, 0] == _board[0, 1] && _board[0, 0] == _board[0, 2]) ||
               (_board[1, 0] != null && _board[1, 0] == _board[1, 1] && _board[1, 0] == _board[1, 2]) ||
               (_board[2, 0] != null && _board[2, 0] == _board[2, 1] && _board[2, 0] == _board[2, 2]);
    }
}