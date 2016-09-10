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

	    [Test()]
	    public void ShouldMoveToWaitingForInputStateAfterGuessing()
	    {
	        GuessIsHigher guess = new GuessIsHigher();
	        Guesser guesser = new Guesser();

	        Assert.IsInstanceOf<WaitingForInput>(guess.handleInput(guesser, KeyCode.UpArrow));

	    }

	}
}
