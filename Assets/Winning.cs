using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Thomsen.GuessingGame
{
	public class Winning
	{
		public void RestartGame(Guesser guess, int min, int max)
		{
			guess.currentMax = max;
			guess.currentMin = min;
		}

	}

}
