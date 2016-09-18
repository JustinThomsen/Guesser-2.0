using NUnit.Framework;
using UnityEngine;

namespace Thomsen.GuessingGame.Assets.Editor

{
	[TestFixture()]
	public class GuessIsHigherTest
	{
	    [Test()]
	    public void ShouldPromptWithHigherGuessWhenGuessIsHigher()
	    {
	        GuessIsHigher guess = new GuessIsHigher();
	        Guesser guesser = new Guesser();
	        guesser.currentMin = 1;
	        guesser.currentGuess = 500;
	        guesser.currentMax = 1000;
//This test has to do 2 things - it has to validate that the prompting occured via moving to waiting for input
//and validate that the guess was higher - at least I think it does but I dont like it.
	        Assert.IsInstanceOf<WaitingForInput>(guess.HandleInput(guesser, KeyCode.UpArrow));

	        Assert.AreEqual(750, guesser.currentGuess);
	    }

		[Test()]
        public void ShouldSetCurrentMinToCurrentGuessOnButtonPressUp ()
        {
            GuessIsHigher higherGuess = new GuessIsHigher();
            Guesser guesser = new Guesser();
            guesser.currentMin = 1;
            guesser.currentGuess = 500;

            higherGuess.HandleInput(guesser, KeyCode.UpArrow);

            Assert.AreEqual (500, guesser.currentMin);

        }

	    [Test()]
        public void ShouldGuessAverageOfCurrentMaxAndCurrentGuessOnButtonPressUp()
        {
//this test is kind of a duplicate of the first test - maybe we can change what we expect (the test name?)
            GuessIsHigher higherGuess = new GuessIsHigher();
            Guesser guesser = new Guesser();
            guesser.currentMax = 1000;
            guesser.currentGuess = 500;

            higherGuess.HandleInput(guesser, KeyCode.UpArrow);

            Assert.AreEqual(750, guesser.currentGuess);
        }

	}
}
