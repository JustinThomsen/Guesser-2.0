using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEditorInternal;
using UnityEngine.UI;


namespace Thomsen.GuessingGame
{
    public interface IGameState
    {
        String printOptions(Guesser guesser);
        IGameState handleInput(Guesser guesser, KeyCode code);
    }

    public class GuessingGame : MonoBehaviour {

        public Text text;
        public Guesser guesser = new Guesser ();
        private IGameState currentState;
	    public Winning winning = new Winning ();
        public KeyCode code;
        private KeyCode emptyCode;

        void Start () {

            StartGame();
        }

        void Update () {

            print(currentState.printOptions(guesser));
            currentState = currentState.handleInput(guesser, code);
            code = emptyCode;

            if (Input.GetKeyDown("up"))
            {
                code = KeyCode.UpArrow;
                //guesser.Guess(guesser.currentMin, guesser.currentMax, KeyCode.UpArrow);
                    //print (guesser.currentGuess);
            }
            else if (Input.GetKeyDown("down"))
            {
                code = KeyCode.DownArrow;
                //guesser.Guess(guesser.currentMin, guesser.currentMax, KeyCode.DownArrow);
            }
            else if (Input.GetKeyDown("return")||Input.GetKeyDown("enter"))
            {
                code = KeyCode.Return;
            }
        }


        void StartGame ()
        {

                currentState = new WaitingForInput();
                guesser.currentMax = 1000;
                guesser.currentMin = 1;
                print ("================================================\n");
                print ("Welcome to Number Wizard\n");
                print ("Pick a number in your head and punch a baby seal.\n");
                print ("Max value is " + guesser.currentMax +"\n");
                print ("Min value is " + guesser.currentMin + "\n");

                Instructions();

        }


    //	void RightAnswer() {
    //		print ("Your number is " + guesser.currentGuess + "\n");
    //		//print (guess+ "g"+max+"max"+min+"min");
    //		Winning();
    //	}
        void Instructions () {
            print("Is the # higher or lower than " + guesser.currentGuess + "\n");
            print ("[UP] for higher; [DOWN] for lower; [RETURN] for equal\n");
        }
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