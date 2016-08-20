using UnityEngine;
using System.Collections;
using System.Collections.Generic;


namespace Thomsen.GuessingGame
{

public class GuessingGame : MonoBehaviour {
	
	Guesser guessy = new Guesser ();
	public Winning winning = new Winning ();
//	List<int> guesses = new List<int>();
//	int max;
//	int initialmax;
//	int min;
//	int initialmin;
//	double guess;
//	int count;
//	int diff;
//	double initialguess;
	KeyCode code;
		
	void Start () {
		
		StartGame();
	}
	
	void Update () {

		if (Input.GetKeyDown("up")) {
				guessy.Guess(guessy.currentMin, guessy.currentMax, KeyCode.UpArrow);
				print (guessy.currentGuess);
		}
		else if (Input.GetKeyDown("down")) {
				guessy.Guess(guessy.currentMin, guessy.currentMax, KeyCode.DownArrow);
		}
		else if (Input.GetKeyDown("return")||Input.GetKeyDown("enter")) {
				winning.RestartGame (guessy,1,1000);
		}
	}
	

	void StartGame () {
		
		//max = 1000;
		//initialmax = max;
		//min = 1;
		//initialmin = min;
		//guess = System.Math.Round (((double)max + (double)min) / 2);
		//diff = System.Math.Abs (max-min);
		//count = 1;
		//initialguess = guess;
			guessy.currentMax = 1000;
			guessy.currentMin = 1;
//			diff = guessy.currentMax - guessy.currentMin;
//			guessy.currentGuess = (int)System.Math.Round (((double)guessy.currentMax + (double)guessy.currentMin) / 2);
			print ("================================================\n");
			print ("Welcome to Number Wizard\n");
			print ("Pick a number in your head and punch a baby seal.\n");
		
			print ("Max value is " + guessy.currentMax +"\n");
			print ("Min value is " + guessy.currentMin + "\n");
			
			Instructions();

		//max = max + 1;
		//min = min - 1;
	}

		
//	void RightAnswer() {
//		print ("Your number is " + guessy.currentGuess + "\n");
//		//print (guess+ "g"+max+"max"+min+"min");
//		Winning();
//	}
	void Instructions () {
		print("Is the # higher or lower than " + guessy.currentGuess + "\n");
		print ("[UP] for higher; [DOWN] for lower; [RETURN] for equal\n");
	}
//	void NextGuess () {
//		
//		guessy.count ++;
//		guessy.currentGuess = (int) System.Math.Round (((double)guessy.currentMax + (double)guessy.currentMin) / 2);
//		diff = Mathf.Abs (guessy.currentMax-guessy.currentMin);
//		print (guess+ "g"+max+"max"+min+"min"+diff+"\n");
//		Instructions();
//
//	}
//	
//	void Liar () {
//		print ("You are a liar.  You should move to Portland.");
//		StartGame();
//	}
//	
//	void Winning () {
//		print ("I won in " + guessy.count +" guesses. Have a safe flight.\n");
//		StartGame();
//	}
	// Update is called once per frame
	//liars 50 = guess - but pick up or down on the first guess 
	//
	
}
}