namespace TicTacToeKata.Test {
    public class Tests {
        [SetUp]
        public void Setup() {
        }

        [Test]
        public void begin_with_empty_board_game() {
            var game = new TicTacToe();
            var board = game.Board;
            Assert.Pass();
        }
    }

    public class TicTacToe {
        public string[,] Board = new string[3, 3];
     

      

    }
}