using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  // Needed to load scenes

public class LevelManager : MonoBehaviour {

    public bool dificultad;
    //  This method will allow us to jump to a specific scene, using its name.
    public void LoadLevel0(string levelName) {
        Seer.min = 1;
        Seer.max = 501;
        Seer.attempts = 5;
        SceneManager.LoadScene(levelName);
        
    }

    public void LoadLevel1(string levelName)
    {
        Seer.min = 1;
        Seer.max = 1001;
        Seer.attempts = 3;
        SceneManager.LoadScene(levelName);
    }

    //  This method will terminate the game application in any platform but Web.
    public void EndGame() {
        Application.Quit();
    }


}
