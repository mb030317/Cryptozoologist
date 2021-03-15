using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotesSystem : MonoBehaviour
{
    public GameObject mainScreen;
    public GameObject noteScreen;

    public GameSystem thisGameSystem;

    void Start()
    {
        thisGameSystem = GetComponent<GameSystem>();
    }

    public void notePress()
    {
        noteScreen.SetActive(true);
        mainScreen.SetActive(false);
    }

    public void backPress()
    {
        noteScreen.SetActive(false);
        mainScreen.SetActive(true);

        thisGameSystem.resetMainText();
    }
}
