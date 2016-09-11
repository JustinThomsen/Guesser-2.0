using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Thomsen.GuessingGame
{
	public class GuessIsLower : IGameState
	{

	    public string printOptions(Guesser guesser)
	    {
	        return null;
	    }

	    public IGameState handleInput(Guesser guesser, KeyCode code)
	    {
	        guesser.Guess(guesser.currentMin, guesser.currentGuess, KeyCode.DownArrow);
	        return new WaitingForInput();
	    }
	}

}
