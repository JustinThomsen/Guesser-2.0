
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Thomsen.GuessingGame
{
	public class Guesser
	{
		public int currentMin;
		public int currentMax;
		public int currentGuess;
		public int guess;
		public double Guess (double min, double max, KeyCode code)
		{
			currentMin = (int)min;
			currentMax = (int)max;
			currentGuess = (int)(min + max)/2;
			switch (code)
			{
			    case KeyCode.UpArrow:
			        currentMin = currentGuess;
			        guess = (currentMax + currentGuess) / 2;
			        return guess;
			    case KeyCode.DownArrow:
			        currentMax = currentGuess;
			        guess = (currentMin + currentGuess) / 2;
			        return guess;
			    default:
			        return currentGuess;
			}
		}

	}

}
