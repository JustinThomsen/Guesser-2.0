using UnityEngine;

namespace Thomsen.GuessingGame
{
	public class GuessIsHigher : IGameState
	{
	    public string printOptions(Guesser guesser)
	    {
	        return "Guessing Higher";
	    }

	    public IGameState handleInput(Guesser guesser, KeyCode code)
	    {
	        guesser.Guess(guesser.currentGuess, guesser.currentMax);
	        return new WaitingForInput();
	    }
	}

}
