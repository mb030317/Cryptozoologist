using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ExploreSystem : MonoBehaviour
{
    public TextMeshProUGUI gameText;
    public GameObject mainMenu;
    public GameObject exploreMenu;
    public GameObject map;

    public GameSystem thisGameSystem;
    public CryptidManager thisCryptidManager;
    public TravelSystem thisTravelSystem;

    public string[] thisCryptid; //this variable holds the data for this rounds cryptid

    int randomDialogue; //this int is used to assign random dialogues later in the script

    public bool visitedLibrary = false;
    public bool visitedBar = false;
    public bool visitedCH = false;

    string libraryText;
    string barText;
    string CHText;

    private void Start()
    {
        thisGameSystem = GetComponent<GameSystem>();
        thisCryptidManager = GetComponent<CryptidManager>();
        thisTravelSystem = GetComponent<TravelSystem>();

        switch (thisCryptidManager.thisCryptid) //assigns thisCryptid to this rounds cryptid
        {
            case "Mothman":
                thisCryptid = thisCryptidManager.mothman;
                break;
            case "Bigfoot":
                thisCryptid = thisCryptidManager.bigfoot;
                break;
            case "Nessie":
                thisCryptid = thisCryptidManager.nessie;
                break;
            default:
                break;
        }

    }

    public void explorePress()
    {
        mainMenu.SetActive(false);
        map.SetActive(false);
        exploreMenu.SetActive(true);

        gameText.text = "Where would you like to ask around first?";
    }

    public void backPress()
    {
        exploreMenu.SetActive(false);
        map.SetActive(true);
        mainMenu.SetActive(true);

        thisGameSystem.resetMainText();
    }

    public void libraryPress()
    {
        randomDialogue = Random.Range(0, 6);

        if(visitedLibrary == false)
        {
            switch (randomDialogue) //assigns library dialogue for this round
            {
                case 0:
                    libraryText = "Yeah I saw something come through here, it went towards " + thisTravelSystem.nextLocation + ".";
                    break;
                case 1:
                    libraryText = "You just missed it! It left town headed for " + thisTravelSystem.nextLocation + ".";
                    break;
                case 2:
                    libraryText = "It was definitely here but not anymore... I think it went towards " + thisTravelSystem.nextLocation + ".";
                    break;
                case 3:
                    libraryText = "Man I've never seen something go that fast. It left towards " + thisTravelSystem.nextLocation + ".";
                    break;
                case 4:
                    libraryText = "You better hurry! Last I saw it was going towards " + thisTravelSystem.nextLocation + "!";
                    break;
                case 5:
                    libraryText = "You better be careful, it left town a minute ago headed for " + thisTravelSystem.nextLocation + ".";
                    break;
                default:
                    break;
            }
        }

        gameText.text = libraryText;
        visitedLibrary = true;        
    }

    public void barPress()
    {
        randomDialogue = Random.Range(0, 6);

        if(visitedBar == false)
        {
            switch (randomDialogue) //assigns bar dialogue for this round
            {
                case 0:
                    barText = "Yeah I saw somethin', it was huge and " + thisCryptid[2] + ".";
                    break;
                case 1:
                    barText = "You wouldn't believe it! Some giant, " + thisCryptid[2] + " creature came through here just the other day!";
                    break;
                case 2:
                    barText = "Yeah I saw this big creature using its " + thisCryptid[1] + " to get around.";
                    break;
                case 3:
                    barText = "I saw something using " + thisCryptid[1] + " to move.";
                    break;
                case 4:
                    barText = "Yeah this big thing came through the other day and attacked " + thisCryptid[3] + ".";
                    break;
                case 5:
                    barText = "This huge frickin monster came through here and attacked " + thisCryptid[3] + "!";
                    break;
                default:
                    break;
            }
        }

        gameText.text = barText;
        visitedBar = true;
    }

    public void chPress()
    {
        randomDialogue = Random.Range(0, 6);

        if(visitedCH == false)
        {
            switch (randomDialogue)
            {
                case 0:
                    CHText = "Yeah this really weird " + thisCryptid[2] + " creature came in here the other day.";
                    break;
                case 1:
                    CHText = "I saw this huge " + thisCryptid[2] + " creature in here the other day.";
                    break;
                case 2:
                    CHText = "There was this super weird thing using its  " + thisCryptid[1] + " to get around.";
                    break;
                case 3:
                    CHText = "I saw something using " + thisCryptid[1] + " to move.";
                    break;
                case 4:
                    CHText = "We're getting reports that the creature has been attacking " + thisCryptid[3] + ".";
                    break;
                case 5:
                    CHText = "Apparently the monster has been attacking " + thisCryptid[3] + "!";
                    break;
                default:
                    break;
            }
        }

        gameText.text = CHText;
        visitedCH = true;

    }

    public void resetExplore()
    {
        visitedBar = false;
        visitedLibrary = false;
        visitedCH = false;

        barText = "";
        libraryText = "";
        CHText = "";
    }
}
