using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Bowling.BDD
{
    [Binding]
    public class BowlingSteps
    {
        private Game game;

        [Given(@"a new bowling game")]
        public void GivenANewBowlingGame()
        {
            game = new Game();
        }

        [When(@"I roll the ball into the gutter 20 times")]
        public void WhenIRollTheBallIntoTheGutter20Times()
        {
            DoRolls(20, 0);
        }


        [When(@"I do a strike in the first frame")]
        public void WhenIDoAStrikeInTheFirstFrame()
        {
            DoStrike();
        }

        [When(@"Hit four pins in the next roll")]
        public void WhenHitFourPinsInTheNextRoll()
        {
            game.Roll(4);
        }

        [Then(@"the score should be 24")]
        public void ThenTheScoreShouldBe24()
        {
            Assert.AreEqual(24, game.Score);
        }

        [When(@"I do 12 consecutive strikes")]
        public void WhenIDo12ConsecutiveStrikes()
        {
            DoRolls(12,10);
        }

        [Then(@"the score should be 300")]
        public void ThenTheScoreShouldBe300()
        {
            Assert.AreEqual(300, game.Score);
        }

        [Then(@"the score should be 0")]
        public void ThenTheScoreShouldBe0()
        {
            Assert.AreEqual(0, game.Score);
        }

        [When(@"I roll the ball 20 times and hit 1 pin per roll")]
        public void WhenIRollTheBall20TimesAndHit1PinPerRoll()
        {
            DoRolls(20, 1);
        }

        [Then(@"the score should be 20")]
        public void ThenTheScoreShouldBe20()
        {
            Assert.AreEqual(20, game.Score);
        }

        [When(@"I do a spare in the first frame")]
        public void WhenIDoASpareInTheFirstFrame()
        {
            DoSpare();
        }

        [When(@"Hit tree pins in the next roll")]
        public void WhenHitTreePinsInTheNextRoll()
        {
            game.Roll(3);
        }

        [When(@"throw the ball in the gutter on next 17 rolls")]
        public void WhenThrowTheBallInTheGutterOnNext17Rolls()
        {
            DoRolls(17, 0);
        }

        [Then(@"the score should be 16")]
        public void ThenTheScoreShouldBe16()
        {
            Assert.AreEqual(16, game.Score);
        }

        private void DoRolls(int numberOfRolls, int numberOfPins)
        {
            for (int rollNumber = 0; rollNumber < numberOfRolls; rollNumber++)
            {
                game.Roll(numberOfPins);
            }
        }

        private void DoSpare()
        {
            game.Roll(3);
            game.Roll(7);
        }

        private void DoStrike()
        {
            game.Roll(10);
        }
    }
}
