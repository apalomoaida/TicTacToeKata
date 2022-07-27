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
            var position = new Position(0, 0);
            game.Move(position);
            game.GetPosition(position).Should().Be("X");
        }
        [Test]
        public void do_second_movement_with_0() {
            var game = new TicTacToe();
            var position1 = new Position(0, 0);
            var position2 = new Position(0, 1);
            game.Move(position1);
            game.Move(position2);
            game.GetPosition(position2).Should().Be("0");
        }  
        [Test]
        public void do_third_movement_with_X() {
            var game = new TicTacToe();
            var position1 = new Position(0, 0);
            var position2 = new Position(0, 1);
            var position3 = new Position(0, 2);
            game.Move(position1);
            game.Move(position2);
            game.Move(position3);
            game.GetPosition(position3).Should().Be("X");
        }   
        [Test]
        public void return_current_active_player() {
            var game = new TicTacToe();
            game.GetCurrentPLayerToken().Should().Be("X");
        }
    }
}