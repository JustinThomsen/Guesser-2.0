using UnityEngine;

namespace Thomsen.GuessingGame
{
	public class GuessIsLower : IGameState
	{
	    public string PrintOptions(Guesser guesser)
	    {
	        GuessingGame.print("Guessing Lower");
	        return "";
	    }

	    public IGameState HandleInput(Guesser guesser, KeyCode code)
	    {
	        guesser.Guess(guesser.currentMin, guesser.currentGuess);
	        return new WaitingForInput();
	    }
	}

}
