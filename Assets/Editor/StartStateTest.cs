using NUnit.Framework;
using Thomsen.GuessingGame;
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
	        Guesser guesser = new Guesser();

	        Assert.IsInstanceOf<WaitingForInput>(startState.handleInput(guesser, KeyCode.A));
	    }

	    [Test()]
	    public void ShouldSetCurrentMaxTo1000AfterStart()
	    {
	        StartState startState = new StartState();
	        Guesser guesser = new Guesser();

	        startState.handleInput(guesser, KeyCode.A);

	        Assert.AreEqual(1000, guesser.currentMax);
	    }

	    [Test()]
	    public void ShouldSetCurrentMinTo1AfterStart()
	    {
	        StartState startState = new StartState();
	        Guesser guesser = new Guesser();

	        startState.handleInput(guesser, KeyCode.A);

	        Assert.AreEqual(1, guesser.currentMin);
	    }
	}
}
