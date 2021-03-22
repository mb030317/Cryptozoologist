using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameSystem : MonoBehaviour
{
    public string startingLocation;
    public bool discoveredCryptid;

    //other scripts
    TravelSystem thisTravelSystem;

    //text objects
    public string mainScreenText;
    public TextMeshProUGUI gameText;
    public TextMeshProUGUI moneyText;

    //gameplay ints
    public int correctTravels = 0;
    public int money;

    //Game objects for win and loss states
    public GameObject[] menus;
    public GameObject winMenu;
    public GameObject loseMenu;

    // Start is called before the first frame update
    void Start()
    {
        thisTravelSystem = GetComponent<TravelSystem>();

        money = 100;

        startingLocation = thisTravelSystem.startingLocation;

        gameText.text = "There has been a cryptid sighting in " + startingLocation + "! Ask around to track the creature down!";
        mainScreenText = "There has been a cryptid sighting in " + startingLocation + "! Ask around to track the creature down!";
    }

    public void Update()
    {
        if(correctTravels >= 4 && discoveredCryptid == true) //win state
        {
            winState();
        }

        if(money <= 0) //lose state
        {
            loseState();
        }
    }

    public void resetMainText() //this function is used to reset the main screen text whenever we return
    {
        gameText.text = mainScreenText;
    }

    public void spendMoney(int moneySpent) //this function is used to change the money variable
    {
        money = money - moneySpent; //subtracts money
        moneyText.text = "$" + money; //displays new money value
    }

    public void winState()
    {
        for(int i = 0; i < menus.Length; i++) //turns off all of the other menus
        {
            menus[i].SetActive(false);
        }

        winMenu.SetActive(true); //turn on the win menu

    }

    public void loseState()
    {
        for (int i = 0; i < menus.Length; i++) //turns off all of the other menus
        {
            menus[i].SetActive(false);
        }

        loseMenu.SetActive(true); //turn on the lose menu
    }

    public void restartGame() //restarts the scene
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void quitGame() //quits the game
    {
        Application.Quit();
    }

}
