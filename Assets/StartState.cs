using UnityEngine;

namespace Thomsen.GuessingGame
{
	public class StartState : IGameState
	{
	    public string PrintOptions(Guesser guesser)
	    {
	        GuessingGame.print("================================================\n" +
	        "Welcome to Guesser 2.0 \n");
	        GuessingGame.print("Pick a number in your head and punch a baby seal.\n" +
	                           "Max value is " + guesser.currentMax + "\n");
	        GuessingGame.print("Min value is " + guesser.currentMin + "\n");
	        return "";
	    }

	    public IGameState HandleInput(Guesser guesser, KeyCode code)
	    {
	        guesser.currentMax = 1000;
	        guesser.currentMin = 1;
	        guesser.currentGuess = guesser.Guess(guesser.currentMin, guesser.currentMax);
	        return new WaitingForInput();
	    }
	}

}
