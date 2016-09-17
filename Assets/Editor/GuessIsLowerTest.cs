using NUnit.Framework;
using UnityEngine;

namespace Thomsen.GuessingGame.Assets.Editor

{
	[TestFixture()]
	public class GuessIsLowerTest
	{
	    [Test()]
	    public void ShouldPromptWithLowerGuessWhenGuessIsLower()
	    {
	        GuessIsLower guess = new GuessIsLower();
	        Guesser guesser = new Guesser();
	        guesser.currentMin = 1;
	        guesser.currentGuess = 500;
	        guesser.currentMax = 1000;

	        guess.HandleInput(guesser, KeyCode.DownArrow);

	        Assert.AreEqual(250, guesser.currentGuess);

	    }

	    /*[Test()]
	    public void ShouldGuessAverageOfCurrentMinAndCurrentGuessOnButtonPressDown()
	    {
	        Guesser guesser = new Guesser();

	        Assert.AreEqual(250, guesser.Guess(1, 1000));

	    }

	    [Test()]
	    public void ShouldSetNewMaxEqualToCurrentGuessAfterButtonPressDown()
	    {
	        Guesser guesser = new Guesser();

	        guesser.Guess(1, 1000);

	        Assert.AreEqual(500, guesser.currentMax);


	    }
*/
	}
}
