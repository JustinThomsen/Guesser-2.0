using NUnit.Framework;
using Thomsen.GuessingGame;
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

	        guess.handleInput(guesser, KeyCode.UpArrow);

	        Assert.AreEqual(750, guesser.currentGuess);
	    }

/*		[Test()]
                public void ShouldSetCurrentMinToCurrentGuessOnButtonPressUp ()
                {
                    Guesser guesser = new Guesser ();

                    guesser.Guess (1, 1000);

                    Assert.AreEqual (500, guesser.currentMin);

                }*/

/*	    [Test()]
                public void ShouldGuessAverageOfCurrentMaxAndCurrentGuessOnButtonPressUp()
                {
                    Guesser guesser = new Guesser();

                    Assert.AreEqual(750, guesser.Guess(1, 1000));

                }*/

	}
}
