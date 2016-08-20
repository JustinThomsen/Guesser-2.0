
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Thomsen.GuessingGame
{
	public class Guesser : IGameState
	{
		public int CurrentMin;
		public int CurrentMax;
		public int CurrentGuess;
		public int guess;
		public double Guess (double min, double max, KeyCode code)
		{
			CurrentMin = (int)min;
			CurrentMax = (int)max;
			CurrentGuess = (int)(min + max)/2;
			switch (code)
			{
			    case KeyCode.UpArrow:
			        CurrentMin = CurrentGuess;
			        guess = (CurrentMax + CurrentGuess) / 2;
			        return guess;
			    case KeyCode.DownArrow:
			        CurrentMax = CurrentGuess;
			        guess = (CurrentMin + CurrentGuess) / 2;
			        return guess;
			    default:
			        return CurrentGuess;
			}
		}

	    public string PrintOptions()
	    {
	        throw new NotImplementedException();
	    }

	    public IGameState HandleInput(KeyCode code)
	    {
	        throw new NotImplementedException();
	    }
	}

}
