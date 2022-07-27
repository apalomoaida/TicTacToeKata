using System.Linq;
using TicTacToeGame;

namespace TicTacToeKata.Test {
    public class Tests {
        [SetUp]
        public void Setup() {
        }

        [Test]
        public void begin_with_empty_board_game() {
            var game = new TicTacToe();
            game.IsBoardEmpty.Should().BeTrue();
        }  
        [Test]
        public void do_first_movement_whith_x() {
            var game = new TicTacToe();
            game.Move(new Position(0, 0));
            game.Board[0,0].Should().Be("X");
        }
    }
}