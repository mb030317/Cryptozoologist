using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AdvancementManager : MonoBehaviour
{

    void Start()
    {
        DontDestroyOnLoad(this.gameObject); //Keeps this object on scene changes
    }

    public void startGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void quitGame()
    {
        Application.Quit();
    }
}
