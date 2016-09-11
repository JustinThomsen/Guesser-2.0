using NUnit.Framework;
using Thomsen.GuessingGame;
using UnityEngine;

namespace Thomsen.GuessingGame.Assets.Editor

{
	[TestFixture()]
	public class WinningTest
	{
	    [Test()]
	    public void ShouldMoveToStateStartOnWin()
	    {
	        Winning winning = new Winning();
	        Guesser guesser = new Guesser();
	        guesser.currentMin = 100;

	        Assert.IsInstanceOf<StartState>(winning.handleInput(guesser, KeyCode.Return));
	    }
	}
}
