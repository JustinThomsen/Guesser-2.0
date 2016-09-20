using UnityEngine;

namespace Thomsen.GuessingGame
{
	public class WaitingForInput : IGameState
	{

	    public string PrintOptions(Guesser guesser)
	    {
	        GuessingGame.print("Is the # higher or lower than " + guesser.currentGuess + "\n");
	        GuessingGame.print("[UP] for higher; [DOWN] for lower; [RETURN] for equal\n");
	        return guesser.currentGuess.ToString();
	    }
        //does it really need the guesser here? Again, some states do, but not this one. or maybe no states do?
	    public IGameState HandleInput(Guesser guesser, KeyCode code)
	    {
	        switch (code)
	        {
	            case KeyCode.UpArrow:
	                return new GuessIsHigher();
	            case KeyCode.DownArrow:
	                return new GuessIsLower();
	            case KeyCode.Return:
	                return new Losing();
	            default:
	                return new WaitingForInput();
	        }
	    }
	}

}
