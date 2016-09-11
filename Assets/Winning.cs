using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Thomsen.GuessingGame
{
	public class Winning : IGameState
	{

	    public string printOptions(Guesser guesser)
	    {
	        return "Your number is " + guesser.currentGuess + ".";
	    }

	    public IGameState handleInput(Guesser guesser, KeyCode code)
	    {
	        return new StartState();
	    }
	}

}
