using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AdvancementManager : MonoBehaviour
{

    public int successfulHunts = 0;

    void Start()
    {
        DontDestroyOnLoad(this.gameObject); //Keeps this object on scene changes
    }

    public void startGame() //start game function for "Play" button on main menu
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void quitGame() //quit game function for "Quit" button on main menu
    {
        Application.Quit();
    }
}
