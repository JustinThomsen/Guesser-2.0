using NUnit.Framework;
using Thomsen.GuessingGame;
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

	        guess.handleInput(guesser, KeyCode.DownArrow);

	        Assert.AreEqual(250, guesser.currentGuess);

	    }

	}
}
