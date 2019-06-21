using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameOver : MonoBehaviour
{
    int score = 0;
    public Text gui;

    // Use this for initialization
    void Start()
    {
        //get our score from playerprefs
        score = PlayerPrefs.GetInt("Score");
        //multiply by 10 as we did on displayed score
        score = score * 1;
    }

    void OnGUI()
    {
        //set our text to our score
        gui.text = score.ToString();
        //if retry button is pressed load scene 0 the game
        if (GUI.Button(new Rect(Screen.width / 2 - 50, Screen.height / 2 + 105, 100, 40), "Start"))
        {
            SceneManager.LoadScene(1);
        }
        //and quit button
        if (GUI.Button(new Rect(Screen.width / 2 - 50, Screen.height / 2 + 155, 100, 40), "Quit"))
        {
            Application.Quit();
        }
    }

}
