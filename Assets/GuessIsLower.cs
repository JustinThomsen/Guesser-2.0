using UnityEngine;

namespace Thomsen.GuessingGame
{
	public class GuessIsLower : IGameState
	{

	    public string printOptions(Guesser guesser)
	    {
	        return "Guessing Lower";
	    }

	    public IGameState handleInput(Guesser guesser, KeyCode code)
	    {
	        guesser.Guess(guesser.currentMin, guesser.currentGuess, KeyCode.DownArrow);
	        return new WaitingForInput();
	    }
	}

}
