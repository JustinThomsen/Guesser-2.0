using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Thomsen.GuessingGame
{
	public class WaitingForInput : IGameState
	{

	    public string printOptions(Guesser guesser)
	    {
	        return "Is the # higher or lower than " + guesser.currentGuess + "\n" +
	        "[UP] for higher; [DOWN] for lower; [RETURN] for equal\n";
	    }

	    public IGameState handleInput(Guesser guesser, KeyCode code)
	    {
	        throw new NotImplementedException();
	    }
	}

}
