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

        [When(@"I throw 5 pins in 21 consecutive rolls")]
        public void WhenIThrow5PinsIn21ConsecutiveRolls()
        {
            DoRolls(21,5);
        }

        [Then(@"the score should be (.*)")]
        public void ThenTheScoreShouldBe(int score)
        {
            Assert.AreEqual(score, game.Score);
        }

        [When(@"I do 12 consecutive strikes")]
        public void WhenIDo12ConsecutiveStrikes()
        {
            DoRolls(12,10);
        }

        [When(@"I roll the ball 20 times and hit 1 pin per roll")]
        public void WhenIRollTheBall20TimesAndHit1PinPerRoll()
        {
            DoRolls(20, 1);
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
