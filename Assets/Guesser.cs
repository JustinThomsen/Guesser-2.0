
using UnityEngine;
//Current defect - can only guess higher every time, or lower everytime.  Any combo leads to a broken game state.
namespace Thomsen.GuessingGame
{
	public class Guesser
	{
		public int currentMin;
		public int currentMax;
	    public int currentGuess;
//		public int guess;
		public int Guess (int min, int max)
		{
			currentMin = min;
			currentMax = max;
		    currentGuess = (currentMin + currentMax) / 2;
		    return currentGuess;
		    /*switch (code)
			{
			    case KeyCode.UpArrow:
			        currentMin = currentGuess;
			        currentGuess = (currentMax + currentGuess) / 2;
			        return currentGuess;
			    case KeyCode.DownArrow:
			        currentMax = currentGuess;
			        currentGuess = (currentMin + currentGuess) / 2;
			        return currentGuess;
			    default:
			        return currentGuess;
			}*/
		}

	}

}
