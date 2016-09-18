using UnityEngine;


namespace Thomsen.GuessingGame
{
	public class Winning : IGameState
	{

	    public string PrintOptions(Guesser guesser)
	    {
	        GuessingGame.print("Your number is " + guesser.currentGuess + ".");
	        return "";
	    }

	    public IGameState HandleInput(Guesser guesser, KeyCode code)
	    {
	        Application.LoadLevel("Win");
	        return new StartState();
	    }
	}

}
