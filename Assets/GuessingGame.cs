using System;
using UnityEngine;
using UnityEngine.UI;

namespace Thomsen.GuessingGame
{
    public interface IGameState
    {
        //not all States need to print stuff - but if I dont have this - I can't use blah.printOptions
        //because not all states would have it
        String PrintOptions(Guesser guesser);
        IGameState HandleInput(Guesser guesser, KeyCode code);
    }

    public class GuessingGame : MonoBehaviour {
        public Guesser guesser = new Guesser ();
        private IGameState currentState;
	    public Winning winning = new Winning ();
        public KeyCode code;
        public Text text;

        void Start ()
        {
            StartGame();
            currentState = new StartState();
            currentState.PrintOptions(guesser);
        }

        void Update ()
        {
            currentState = currentState.HandleInput(guesser, code);
            currentState.PrintOptions(guesser);
            text.text = currentState.PrintOptions(guesser);

            if (Input.GetKeyDown("up"))
            {
                code = KeyCode.UpArrow;
            }
            else if (Input.GetKeyDown("down"))
            {
                code = KeyCode.DownArrow;
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

        public void GuessHigher()
        {
            code = KeyCode.UpArrow;
        }

        public void GuessLower()
        {
            code = KeyCode.DownArrow;
        }

        public void CorrectGuess()
        {
            code = KeyCode.Return;
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