using NUnit.Framework;

namespace Thomsen.GuessingGame.Assets.Editor

{
	[TestFixture()]
	public class GuesserTest
	{
	    [Test()]
	    public void InitialGuessShouldBeAverageOfCurrentMaxAndCurrentMin()
	    {
	        Guesser guesser = new Guesser();

	        Assert.AreEqual(500, guesser.Guess(1, 1000));

	    }

	    [Test()]
	    public void ShouldIncrementGuessCountByOneAfterAGuess()
	    {
	        Guesser guesser = new Guesser();
	        guesser.count = 0;

	        guesser.Guess(1, 1000);

	        Assert.AreEqual(1, guesser.count);

	    }

	    [Test()]
	    public void ShouldGuess750OnHigherGuessWhenCurrentGuessIs500AndMaxIs1000()
	    {
	        Guesser guesser = new Guesser();

	        Assert.AreEqual(750, guesser.Guess(500, 1000));

	    }


	}
}
