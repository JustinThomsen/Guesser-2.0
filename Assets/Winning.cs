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
			guess.CurrentMax = max;
			guess.CurrentMin = min;
		}

	}

}
