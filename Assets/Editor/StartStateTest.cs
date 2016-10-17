using System;
using NSubstitute;
using NUnit.Framework;
using UnityEngine;

namespace Thomsen.GuessingGame.Assets.Editor

{
	[TestFixture()]
	public class StartStateTest
	{
	    [Test()]
	    public void ShouldMoveToWaitingForInputAfterStartForAnyKeypress()
	    {
	        StartState startState = new StartState();
	        var mockGuesser = Substitute.For<Guesser>();
	        mockGuesser.currentMin = 1;
	        mockGuesser.currentGuess = 500;
	        mockGuesser.currentMax = 1000;

	        IGameState result = startState.HandleInput(mockGuesser, KeyCode.UpArrow);

	        Assert.IsInstanceOf<WaitingForInput>(result);
	    }

	    [Test()]
	    public void ShouldSetCurrentMaxTo1000AfterStart()
	    {
	        StartState startState = new StartState();
	        Guesser guesser = new Guesser();

	        startState.HandleInput(guesser, KeyCode.A);

	        Assert.AreEqual(1000, guesser.currentMax);
	    }

	    [Test()]
	    public void ShouldSetCurrentGuessBetweenMinAndMaxAfterStart()
	    {
	        StartState startState = new StartState();
	        Guesser guesser = new Guesser();
	        guesser.currentGuess = 25;

	        startState.HandleInput(guesser, KeyCode.A);

	        Assert.GreaterOrEqual(guesser.currentGuess, guesser.currentMin);
	        Assert.LessOrEqual(guesser.currentGuess, guesser.currentMax);
	        Console.Write(guesser.currentGuess);
	    }

	    [Test()]
	    public void ShouldSetCurrentMinTo1AfterStart()
	    {
	        StartState startState = new StartState();
	        Guesser guesser = new Guesser();
	        guesser.currentMin = 10;

	        startState.HandleInput(guesser, KeyCode.A);

	        Assert.AreEqual(1, guesser.currentMin);
	    }
	}
}
