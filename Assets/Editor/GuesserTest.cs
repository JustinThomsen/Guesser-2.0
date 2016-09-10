using NUnit.Framework;
using Thomsen.GuessingGame;
using UnityEngine;

namespace Thomsen.GuessingGame.Assets.Editor

{
	[TestFixture()]
	public class GuesserTest
	{
		[Test()]
		public void InitialGuessShouldBeAverageOfCurrentMaxAndCurrentMin()
		{
			Guesser guesser = new Guesser ();

			Assert.AreEqual (500, guesser.Guess (1, 1000, KeyCode.A));

		}

		[Test()]
		public void ShouldGuessAverageOfCurrentMaxAndCurrentGuessOnButtonPressUp ()
		{
			Guesser guesser = new Guesser ();

			Assert.AreEqual (750, guesser.Guess (1, 1000, KeyCode.UpArrow));

		}

		[Test()]
		public void ShouldSetCurrentMinToCurrentGuessOnButtonPressUp ()
		{
			Guesser guesser = new Guesser ();

		    guesser.Guess (1, 1000, KeyCode.UpArrow);

			Assert.AreEqual (500, guesser.currentMin);
			
		}

		[Test()]
		public void ShouldGuessAverageOfCurrentMinAndCurrentGuessOnButtonPressDown ()
		{
			Guesser guesser = new Guesser ();

			Assert.AreEqual (250, guesser.Guess (1, 1000, KeyCode.DownArrow));

		}

		[Test()]
		public void ShouldSetNewMaxEqualToCurrentGuessAfterButtonPressDown ()
		{
			Guesser guesser = new Guesser ();

			guesser.Guess (1, 1000, KeyCode.DownArrow);

			Assert.AreEqual (500, guesser.currentMax);


		}
	}
}
