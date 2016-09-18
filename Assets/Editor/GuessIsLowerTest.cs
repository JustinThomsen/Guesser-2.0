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
//Same duplication here
	        GuessIsLower guess = new GuessIsLower();
	        Guesser guesser = new Guesser();
	        guesser.currentMin = 1;
	        guesser.currentGuess = 500;

	        Assert.IsInstanceOf<WaitingForInput>(guess.HandleInput(guesser, KeyCode.DownArrow));

	        Assert.AreEqual(250, guesser.currentGuess);

	    }

	    [Test()]
	    public void ShouldGuessAverageOfCurrentMinAndCurrentGuessOnButtonPressDown()
	    {
	        GuessIsLower guess = new GuessIsLower();
	        Guesser guesser = new Guesser();
	        guesser.currentMin = 1;
	        guesser.currentGuess = 500;
	        guesser.currentMax = 1000;

	        guess.HandleInput(guesser, KeyCode.DownArrow);

	        Assert.AreEqual(250, guesser.currentGuess);
	    }

	    [Test()]
	    public void ShouldSetNewMaxEqualToCurrentGuessAfterButtonPressDown()
	    {
	        GuessIsLower guess = new GuessIsLower();
	        Guesser guesser = new Guesser();
	        guesser.currentMin = 1;
	        guesser.currentGuess = 500;
	        guesser.currentMax = 1000;

	        guess.HandleInput(guesser, KeyCode.DownArrow);

	        Assert.AreEqual(500, guesser.currentMax);
	    }
	}
}
