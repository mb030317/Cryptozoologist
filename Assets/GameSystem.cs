using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameSystem : MonoBehaviour
{
    public TextMeshProUGUI gameText;
    public string startingLocation;

    TravelSystem thisTravelSystem;

    // Start is called before the first frame update
    void Start()
    {
        thisTravelSystem = GetComponent<TravelSystem>();

        startingLocation = thisTravelSystem.startingLocation;

        gameText.text = "There has been a cryptid sighting in " + startingLocation + "! Ask around to track the creature down!";
    }

    // Update is called once per frame
    void Update()
    {

    }
}
