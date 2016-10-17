using NUnit.Framework;
using UnityEngine;
using NSubstitute;

namespace Thomsen.GuessingGame.Assets.Editor

{
	[TestFixture()]
	public class GuessIsLowerTest
	{
	    [Test()]
	    public void ShouldPromptWithLowerGuessWhenGuessIsLower()
	    {
	        GuessIsLower guess = new GuessIsLower();
	        var mockGuesser = Substitute.For<Guesser>();
	        mockGuesser.currentMin = 1;
	        mockGuesser.currentGuess = 500;
	        mockGuesser.currentMax = 1000;

	        IGameState result = guess.HandleInput(mockGuesser, KeyCode.UpArrow);

	        Assert.IsInstanceOf<WaitingForInput>(result);
	        mockGuesser.Received().Guess(1,500);
	    }
	}
}
