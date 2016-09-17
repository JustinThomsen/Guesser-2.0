using UnityEngine;


namespace Thomsen.GuessingGame
{
	public class Winning : IGameState
	{

	    public string PrintOptions(Guesser guesser)
	    {
	        return "Your number is " + guesser.currentGuess + ".";
	    }

	    public IGameState HandleInput(Guesser guesser, KeyCode code)
	    {
	        return new StartState();
	    }
	}

}
