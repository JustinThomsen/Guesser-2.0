using System;
using UnityEngine;
using UnityEngine.UI;

namespace Thomsen.GuessingGame
{
    public interface IGameState
    {
        //not all States need to print stuff - but if I dont have this - I can't use blah.printOptions
        //because not all states would have it
        String printOptions(Guesser guesser);
        IGameState handleInput(Guesser guesser, KeyCode code);
    }

    public class GuessingGame : MonoBehaviour {

        public Text text;
        public Guesser guesser = new Guesser ();
        private IGameState currentState;
	    public Winning winning = new Winning ();
        public KeyCode code;
//        private KeyCode emptyCode;

        void Start ()
        {
            StartGame();
            currentState = new StartState();
            print(currentState.printOptions(guesser));
        }

        void Update ()
        {
            currentState = currentState.handleInput(guesser, code);
            print(currentState.printOptions(guesser));
            print(code);
            //print(guesser.currentGuess);

            if (Input.GetKeyDown("up"))
            {
                code = KeyCode.UpArrow;
//                guesser.Guess(guesser.currentGuess, guesser.currentMax, KeyCode.UpArrow);
                print(guesser.currentGuess);
                //print (guesser.currentGuess);
            }
            else if (Input.GetKeyDown("down"))
            {
                code = KeyCode.DownArrow;
//                guesser.Guess(guesser.currentMin, guesser.currentGuess, KeyCode.DownArrow);
            }
            else if (Input.GetKeyDown("return") || Input.GetKeyDown("enter"))
            {
                code = KeyCode.Return;
            }
            else code = KeyCode.None;
        }


        public void StartGame ()
        {
            guesser.currentMax = 1000;
            guesser.currentMin = 1;
            guesser.Guess(guesser.currentMin, guesser.currentMax);
        }


    //	void RightAnswer() {
    //		print ("Your number is " + guesser.currentGuess + "\n");
    //		//print (guess+ "g"+max+"max"+min+"min");
    //		Winning();
    //	}

    //	void NextGuess () {
    //
    //		guesser.count ++;
    //		guesser.currentGuess = (int) System.Math.Round (((double)guesser.currentMax + (double)guesser.currentMin) / 2);
    //		diff = Mathf.Abs (guesser.currentMax-guesser.currentMin);
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
    //		print ("I won in " + guesser.count +" guesses. Have a safe flight.\n");
    //		StartGame();
    //	}
        // Update is called once per frame
        //liars 50 = guess - but pick up or down on the first guess
        //
	
    }
}