using CricketGame;
using System;
using Xunit;

namespace CricketGame.Tests
{
    public class CricketGameTests
    {
        [Fact()]
        public void Score_NegativeValue_TotalUnchanged()
        {
            var game = new Game();
            game.Score(1);
            game.Score(-1);
            Assert.Equal(game.TotalScore, 1);
        }

        [Fact]
        public void When_Batter_Gets_Out_The_Game_Should_End()
        {
            var game = new Game();
            game.Score(10);
            game.Score(-1);
            Assert.True(game.IsFinished);
        }

        [Fact]
        public void When_Batter_gets_Out_Score_Cannot_Increase()
        {
            var game = new Game();
            game.Score(10);
            game.Score(-1);
            game.Score(5);
            Assert.Equal(game.TotalScore,10);
        }
    }
}
