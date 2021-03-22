using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameSystem : MonoBehaviour
{
    public string startingLocation;

    //other scripts
    TravelSystem thisTravelSystem;

    //text objects
    public string mainScreenText;
    public TextMeshProUGUI gameText;

    //gameplay ints
    public int correctTravels = 0;
    public int money = 100;

    // Start is called before the first frame update
    void Start()
    {
        thisTravelSystem = GetComponent<TravelSystem>();

        startingLocation = thisTravelSystem.startingLocation;

        gameText.text = "There has been a cryptid sighting in " + startingLocation + "! Ask around to track the creature down!";
        mainScreenText = "There has been a cryptid sighting in " + startingLocation + "! Ask around to track the creature down!";
    }

    public void resetMainText() //this function is used to reset the main screen text whenever we return
    {
        gameText.text = mainScreenText;
    }

}
