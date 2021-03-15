using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TravelSystem : MonoBehaviour
{
    public string[] locations; //0 columbus, 1 athens, 2 cleveland, 3 cincinnati, 4 dayton
    public string startingLocation;
    public string currentLocation;
    public string nextLocation;
    public string bonusLocation;

    //grabs the main and travel screens
    public GameObject mainScreen;
    public GameObject travelScreen;
    public GameObject[] dot; //0 columbus, 1 athens, 2 cleveland, 3 cincinnati, 4 dayton

    public GameSystem thisGameSystem;
    public ExploreSystem thisExploreSystem;

    public TextMeshProUGUI locationText;
    public TextMeshProUGUI gameText;
    public Text[] buttonText; //0 button1, 1 button2


    void Start()
    {
        startingLocation = locations[Random.Range(0, 5)]; //picks a random location to start in

        thisGameSystem = GetComponent<GameSystem>();
        thisExploreSystem = GetComponent<ExploreSystem>();

        currentLocation = startingLocation;

        switch (currentLocation)
        {
            case "Columbus":
                dot[0].SetActive(true);
                break;
            case "Athens":
                dot[1].SetActive(true);
                break;
            case "Cleveland":
                dot[2].SetActive(true);
                break;
            case "Cincinnati":
                dot[3].SetActive(true);
                break;
            case "Dayton":
                dot[4].SetActive(true);
                break;
            default:
                break;
        }
    }

    private void Update() //assign the next and bonus locations in this update function
    {
        if(nextLocation == "" || nextLocation == currentLocation)
        {
            nextLocation = locations[Random.Range(0, 5)];
        }

        if(bonusLocation == "" || bonusLocation == currentLocation || bonusLocation == nextLocation)
        {
            bonusLocation = locations[Random.Range(0, 5)];
        }

        locationText.text = currentLocation + ", Ohio";

        buttonText[0].text = nextLocation;
        buttonText[1].text = bonusLocation;
    }

    public void travelPress() //switches to travel screen
    {
        travelScreen.SetActive(true);
        mainScreen.SetActive(false);
        gameText.text = "Where would you like to go next?";

        switch (nextLocation) //turns on nextlocation dot when entering travel scene
        {
            case "Columbus":
                dot[0].SetActive(true);
                break;
            case "Athens":
                dot[1].SetActive(true);
                break;
            case "Cleveland":
                dot[2].SetActive(true);
                break;
            case "Cincinnati":
                dot[3].SetActive(true);
                break;
            case "Dayton":
                dot[4].SetActive(true);
                break;
            default:
                break;
        }

        switch (bonusLocation) //turns on bonusLocation dot when entering travel scene
        {
            case "Columbus":
                dot[0].SetActive(true);
                break;
            case "Athens":
                dot[1].SetActive(true);
                break;
            case "Cleveland":
                dot[2].SetActive(true);
                break;
            case "Cincinnati":
                dot[3].SetActive(true);
                break;
            case "Dayton":
                dot[4].SetActive(true);
                break;
            default:
                break;
        }
    }

    public void backPress() //switches back to main screen
    {
        travelScreen.SetActive(false);
        mainScreen.SetActive(true);
        thisGameSystem.resetMainText();

        switch (nextLocation) //turns off next location dot when returning to mainscreen
        {
            case "Columbus":
                dot[0].SetActive(false);
                break;
            case "Athens":
                dot[1].SetActive(false);
                break;
            case "Cleveland":
                dot[2].SetActive(false);
                break;
            case "Cincinnati":
                dot[3].SetActive(false);
                break;
            case "Dayton":
                dot[4].SetActive(false);
                break;
            default:
                break;
        }

        switch (bonusLocation) //turns off bonusLocation dot when returning to mainscreen
        {
            case "Columbus":
                dot[0].SetActive(false);
                break;
            case "Athens":
                dot[1].SetActive(false);
                break;
            case "Cleveland":
                dot[2].SetActive(false);
                break;
            case "Cincinnati":
                dot[3].SetActive(false);
                break;
            case "Dayton":
                dot[4].SetActive(false);
                break;
            default:
                break;
        }
    }

    public void locationOnePress()
    {
        currentLocation = nextLocation;
        thisExploreSystem.resetExplore();

        //clear the location dots
        dot[0].SetActive(false);
        dot[1].SetActive(false);
        dot[2].SetActive(false);
        dot[3].SetActive(false);
        dot[4].SetActive(false);

        switch (currentLocation) //turns on the current location dot
        {
            case "Columbus":
                dot[0].SetActive(true);
                break;
            case "Athens":
                dot[1].SetActive(true);
                break;
            case "Cleveland":
                dot[2].SetActive(true);
                break;
            case "Cincinnati":
                dot[3].SetActive(true);
                break;
            case "Dayton":
                dot[4].SetActive(true);
                break;
            default:
                break;
        }

        thisGameSystem.mainScreenText = "Welcome to " + currentLocation + "! Ask around for more information about the creature!";

        travelScreen.SetActive(false);
        mainScreen.SetActive(true);
        thisGameSystem.resetMainText();
    }

    public void locationTwoPress()
    {

    }


}
