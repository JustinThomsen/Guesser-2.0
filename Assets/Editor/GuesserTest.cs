using System;
using NUnit.Framework;
using UnityEngine;

namespace Thomsen.GuessingGame.Assets.Editor

{
	[TestFixture()]
	public class GuesserTest
	{
	    [Test()]
	    public void ShouldIncrementGuessCountByOneAfterAGuess()
	    {
	        Guesser guesser = new Guesser();
	        guesser.count = 0;

	        guesser.Guess(1, 1000);

	        Assert.AreEqual(1, guesser.count);
	    }

	    [Test()]
	    public void ShouldSetMinEqualToNewMin()
	    {
	        Guesser guesser = new Guesser();
	        guesser.currentMin = 222;

	        guesser.Guess(1, 500);

	        Assert.AreEqual(1, guesser.currentMin);
	    }
	    [Test()]
	    public void ShouldSetMaxEqualToNewMax()
	    {
	        Guesser guesser = new Guesser();
	        guesser.currentMax = 777;

	        guesser.Guess(1, 500);

	        Assert.AreEqual(500, guesser.currentMax);
	    }
	    [Test()]
	    public void ShouldGuessNumberBetweenCurrentMinAndCurrentMax()
	    {
	        Guesser guesser = new Guesser();

	        guesser.Guess(500, 1000);

	        Assert.IsTrue(500 < guesser.currentGuess && guesser.currentGuess < 1000);
	    }

	    [Test()]
	    public void GuessShouldBeRandom()
	    {
	        //flaky - random is based on time in millis.
	        Guesser guesser = new Guesser();
	        Guesser guesser2 = new Guesser();

	        guesser.Guess(500, 1000);
	        var expected = guesser.currentGuess;
	        Console.Write(guesser.currentGuess);
	        guesser2.Guess(500, 1000);
	        var actual = guesser2.currentGuess;
	        Console.Write(guesser2.currentGuess);

	        Assert.AreNotEqual(expected, actual);
	    }
	}
}
