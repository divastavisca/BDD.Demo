using System;
using TechTalk.SpecFlow;
using CricketGame;
using Xunit;

namespace CricketGameKata.Specs
{
    [Binding]
    public class BatterScoreSteps
    {
        Game game;

        [Given(@"I started a new game of cricket")]
        public void GivenIStartedANewGameOfCricket()
        {
            game = new Game();
        }
        
        [When(@"Batter gets out")]
        public void WhenBatterGetsOut()
        {
            game.Score(-1);
        }
        
        [Then(@"Batter score should be (.*)")]
        public void ThenBatterScoreShouldBe(int expectedScore)
        {
            Assert.Equal(game.TotalScore, expectedScore);
        }

        [Given(@"Batter scored (.*) runs")]
        public void GivenBatterScoredRuns(int newScore)
        {
            game.Score(newScore);
        }

        [Then(@"game should be finished")]
        public void ThenGameShouldBeFinished()
        {
            Assert.True(game.IsFinished);
        }

        [Given(@"Batter gets out")]
        public void GivenBatterGetsOut()
        {
            game.Score(-1);
        }

        [When(@"Batter scored (.*) runs")]
        public void WhenBatterScoredRuns(int p0)
        {
            game.Score(p0);
        }
    }
}
