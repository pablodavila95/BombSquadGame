﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Seer : MonoBehaviour {
    public static int min;
    public static int max;
    private int guess;
    private LevelManager levelManager;


    public string easy;
    public string hard;
    public static int attempts;
    public Text guessLabel;

	// Use this for initialization
	void Start () {
        levelManager = FindObjectOfType<LevelManager>();
        easyGame();
        ShowGuess();
	}
	

    void easyGame(){
        NextGuess();
    }

    void hardGame()
    {
        min = 1;
        max = 1001;
        NextGuess();
    }

    void NextGuess(){
        guess = Random.Range(min, max);
        attempts--;
    }

    void ShowGuess(){
        if (attempts >= 0)
        {
            guessLabel.text = "Try typing in " + guess + "...";
        }
        else
        {
            levelManager.LoadLevel("Lose");
        }
    }

    public void GuessHigher(){
        min = guess + 1;
        NextGuess();
        ShowGuess();
    }

    public void GuessLower(){
        max = guess;
        NextGuess();
        ShowGuess();
    }

    public void CorrectGuess(){
        levelManager.LoadLevel("Win");
    }


}
