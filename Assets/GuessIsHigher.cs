using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Thomsen.GuessingGame
{
	public class GuessIsHigher : IGameState
	{

	    public string printOptions(Guesser guesser)
	    {
	        throw new NotImplementedException();
	    }

	    public IGameState handleInput(Guesser guesser, KeyCode code)
	    {
	        guesser.Guess(guesser.currentGuess, guesser.currentMax, KeyCode.UpArrow);
	        return new WaitingForInput();
	    }
	}

}
