using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TravelSystem : MonoBehaviour
{
    //location strings
    public string[] locations; //0 columbus, 1 athens, 2 cleveland, 3 cincinnati, 4 dayton
    public string startingLocation;
    public string currentLocation;
    public string nextLocation;
    public string bonusLocation;

    //grabs the main and travel screens and the travel buttons
    public GameObject mainScreen;
    public GameObject travelScreen;
    public GameObject[] dot; //0 columbus, 1 athens, 2 cleveland, 3 cincinnati, 4 dayton
    public RectTransform[] buttonObjects; //0 button1, 1 button2

    //other script components
    public GameSystem thisGameSystem;
    public ExploreSystem thisExploreSystem;

    //text objects
    public TextMeshProUGUI locationText;
    public TextMeshProUGUI gameText;
    public Text[] buttonText; //0 button1, 1 button2

    int buttonLocation = 0;

    public bool correctLocation; //checks to see if the player has visited the correct location


    void Start()
    {
        startingLocation = locations[Random.Range(0, 5)]; //picks a random location to start in
        correctLocation = true; //starts as true because you start in the correct location

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

        if(buttonLocation == 0) //randomly assigns the buttonLocation int on reset
        {
            buttonLocation = Random.Range(1, 3);
        }

        buttonText[0].text = nextLocation;
        buttonText[1].text = bonusLocation;
    }

    public void travelPress() //switches to travel screen
    {
        travelScreen.SetActive(true);
        mainScreen.SetActive(false);
        gameText.text = "Where would you like to go next?";

        if(buttonLocation == 1) //randomizes correct button location
        {
            buttonObjects[0].anchoredPosition = new Vector2(-172.35f, -191.1f);
            buttonObjects[1].anchoredPosition = new Vector2(139.6f, -181.5f);
        }

        else
        {
            buttonObjects[0].anchoredPosition = new Vector2(139.6f, -181.5f);
            buttonObjects[1].anchoredPosition = new Vector2(-172.35f, -191.1f);
        }

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
        buttonLocation = 0; //this will randomize the travel button locations again
        correctLocation = true; //picked the right location
        currentLocation = nextLocation;
        thisGameSystem.correctTravels++; //increases the correctTravels int on the GameSystem script
        thisGameSystem.spendMoney(10); //spends $10 on traveling
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
        buttonLocation = 0; //this will randomize the travel button locations again
        correctLocation = false; //picked the wrong location
        currentLocation = bonusLocation;
        thisGameSystem.spendMoney(10); //spends $10 on traveling
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

        thisGameSystem.mainScreenText = "Welcome to " + currentLocation + "! Things seem quiet here, did you take a wrong turn?";

        travelScreen.SetActive(false);
        mainScreen.SetActive(true);
        thisGameSystem.resetMainText();
    }


}
