using NUnit.Framework;
using Thomsen.GuessingGame;
using UnityEngine;

namespace Thomsen.GuessingGame.Assets.Editor

{
	[TestFixture()]
	public class WaitingForInputTest
	{
	    [Test()]
	    public void ShouldEndInWaitingForInputStateAfterGuessing()
	    {
	        GuessIsHigher guess = new GuessIsHigher();
	        Guesser guesser = new Guesser();

	        Assert.IsInstanceOf<WaitingForInput>(guess.HandleInput(guesser, KeyCode.UpArrow));
	    }

	    [Test()]
	    public void ShouldMoveToGuessIsHigherStateAfterGuessingHigher()
	    {
	        WaitingForInput guess = new WaitingForInput();
	        Guesser guesser = new Guesser();

	        Assert.IsInstanceOf<GuessIsHigher>(guess.HandleInput(guesser, KeyCode.UpArrow));
	    }

	    [Test()]
	    public void ShouldMoveToWinningStateAfterCorrectGuess()
	    {
	        WaitingForInput guess = new WaitingForInput();
	        Guesser guesser = new Guesser();

	        Assert.IsInstanceOf<Winning>(guess.HandleInput(guesser, KeyCode.Return));
	    }

	}
}
