using System;
using System.Collections.Generic;
using System.Text;
using TLC_WebApp.Models;
using Xunit;

namespace XUnitTest
{
    public class CreateGameTest
    {

        [Fact]
        public void TestCreatingNewGameAndGameBoardAndEquals()
        {
            //arrange
            Game game = new Game();
            //act
            GameBoard gameBoard = new GameBoard();
            //assert
            Assert.Equal(game.gb, gameBoard);
        }
        [Fact]
        public void testSendingToDataBase()
        {
            //arrange
            Game game = new Game();
            //act
            game.gb.SendToDatabase();
            string[] testArray = { "0", "0", "0", "0", "0", "0", "0", "0", "0" };
            //assert
            Assert.Equal(game.gb.dBGameBoard, testArray);
        }
        [Fact]
        public void TestAIChoice()
        {
            //arrange
            Game game = new Game();
            //act
            game.gb.SendToDatabase();
            game.AIChoice();
            string[] testArray = { "X", "0", "0", "0", "0", "0", "0", "0", "0" };
            //assert
            Assert.Equal(game.gb.dBGameBoard, testArray);
        }
        [Fact]
        public void TestWin()
        {
            //arrange
            Game game = new Game();
            //act
            game.gb.SendToDatabase();
            game.AIChoice();
            game.AIChoice();
            game.AIChoice(); 
            game.AIChoice();
            game.AIChoice();
            game.AIChoice();
            game.AIChoice();

            //assert
            Assert.True(game.win());
        }
    }
}
