using UnityEngine;


namespace Thomsen.GuessingGame
{
	public class Losing : IGameState
	{

	    public string PrintOptions(Guesser guesser)
	    {
	        GuessingGame.print("Your number is " + guesser.currentGuess + ".");
	        return "Your number is " + guesser.currentGuess + ".";
	    }

	    public IGameState HandleInput(Guesser guesser, KeyCode code)
	    {
	        Application.LoadLevel("Lose");
	        return new StartState();
	    }
	}

}
