using NUnit.Framework;
using UnityEngine;
using NSubstitute;



namespace Thomsen.GuessingGame.Assets.Editor

{
	[TestFixture]
	public class GuessIsHigherTest
	{
	    [Test()]
	    public void ShouldPromptWithHigherGuessWhenGuessIsHigher()
	    {
	        GuessIsHigher guess = new GuessIsHigher();

            //This is my table I will splash the pot Whenever. The Fuck. I want.
	        //To run the verify, we need to have an interface. So Guesser needs an interface.
	        //But how do we set state on the Guesser object if it's an interface?
	        //Maybe we need another object that we pass into the Guesser that represents the current parameters? (and we mock that)

	        //Marking the Guess() method as 'virtual' solved the need for us to use an interface.  Apparently in C#
	        //the new 'hotness' is that everything is an interface.
	        //Uncle Bob says that the L in SOLID would be violated by this because it violates Liskov sub principle.
	        //my tests pass for the right reasons. Im leaving it for now.

	        var mockGuesser = Substitute.For<Guesser>();
	        mockGuesser.currentMin = 1;
	        mockGuesser.currentGuess = 500;
	        mockGuesser.currentMax = 1000;

	        IGameState result = guess.HandleInput(mockGuesser, KeyCode.UpArrow);

	        Assert.IsInstanceOf<WaitingForInput>(result);
	        mockGuesser.Received().Guess(500,1000);
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
