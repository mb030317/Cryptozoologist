using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TravelSystem : MonoBehaviour
{
    public string[] locations;
    public string startingLocation;
    public string nextLocation;

    //grabs the main and travel screens
    public GameObject mainScreen;
    public GameObject travelScreen;


    void Start()
    {
        startingLocation = locations[Random.Range(0, 5)]; //picks a random location to start in        
    }

    public void travelPress() //switches to travel screen
    {
        travelScreen.SetActive(true);
        mainScreen.SetActive(false);
    }

    public void backPress() //switches back to main screen
    {
        travelScreen.SetActive(false);
        mainScreen.SetActive(true);
    }


}
