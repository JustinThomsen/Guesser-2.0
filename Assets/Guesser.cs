namespace Thomsen.GuessingGame
{
	public class Guesser
	{
		public int currentMin;
		public int currentMax;
	    public int currentGuess;
	    public int count;

		public int Guess (int min, int max)
		{
			currentMin = min;
			currentMax = max;
		    currentGuess = (currentMin + currentMax) / 2;
		    count++;
		    return currentGuess;
		}

	}

}
