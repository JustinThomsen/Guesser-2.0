using UnityEngine;

namespace Thomsen.GuessingGame
{
	public class GuessIsHigher : IGameState
	{
	    public string PrintOptions(Guesser guesser)
	    {
	        GuessingGame.print("Guessing Higher");
	        return "";
	    }

	    public IGameState HandleInput(Guesser guesser, KeyCode code)
	    {
	        guesser.Guess(guesser.currentGuess, guesser.currentMax);
	        return new WaitingForInput();
	    }
	}

}
