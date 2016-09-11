using UnityEngine;

namespace Thomsen.GuessingGame
{
	public class StartState : IGameState
	{
	    public string printOptions(Guesser guesser)
	    {
	        return ("================================================\n" +
	        "Welcome to Guesser 2.0\n" +
	        "Pick a number in your head and punch a baby seal.\n" +
	        "Max value is " + guesser.currentMax + "\n" +
	        "Min value is " + guesser.currentMin + "\n");
	    }

	    public IGameState handleInput(Guesser guesser, KeyCode code)
	    {
	        guesser.currentMax = 1000;
	        guesser.currentMin = 1;
	        guesser.Guess(guesser.currentMin, guesser.currentMax, code);
	        return new WaitingForInput();
	    }
	}

}
