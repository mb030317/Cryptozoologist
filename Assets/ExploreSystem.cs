using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ExploreSystem : MonoBehaviour
{
    public TextMeshProUGUI gameText;
    public GameObject mainMenu;
    public GameObject exploreMenu;

    public GameSystem thisGameSystem;
    public CryptidManager thisCryptidManager;

    public string[] thisCryptid; //this variable holds the data for this rounds cryptid

    int randomDialogue; //this int is used to assign random dialogues later in the script

    private void Start()
    {
        thisGameSystem = GetComponent<GameSystem>();
        thisCryptidManager = GetComponent<CryptidManager>();

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
        exploreMenu.SetActive(true);

        gameText.text = "Where would you like to ask around first?";
    }

    public void backPress()
    {
        exploreMenu.SetActive(false);
        mainMenu.SetActive(true);

        thisGameSystem.resetMainText();
    }

    public void libraryPress()
    {
        randomDialogue = Random.Range(0, 6);

        switch (randomDialogue)
        {
            case 0:
                gameText.text = "Yeah I saw something! It was big and had " + thisCryptid[2] + " skin!";
                break;
            case 1:
                gameText.text = "This huge thing came through here, it looked super " + thisCryptid[2] + ".";
                break;
            case 2:
                gameText.text = "This huge thing came through here, it was using its " + thisCryptid[1] + " to get around.";
                break;
            case 3:
                gameText.text = "I saw this big creature getting around with its " + thisCryptid[1] + ".";
                break;
            case 4:
                gameText.text = "This giant monster came through here and attacked " + thisCryptid[3] + "!";
                break;
            case 5:
                gameText.text = "Yeah I saw this weird creature attacking " + thisCryptid[3] + " the other day.";
                break;
            default:
                break;
        }
    }

    public void barPress()
    {
        randomDialogue = Random.Range(0, 6);

        switch (randomDialogue)
        {
            case 0:
                gameText.text = "Yeah I saw somethin', it was huge and " + thisCryptid[2] + ".";
                break;
            case 1:
                gameText.text = "You wouldn't believe it! Some giant, " + thisCryptid[2] + " creature came through here just the other day!";
                break;
            case 2:
                gameText.text = "Yeah I saw this big creature using its " + thisCryptid[1] + " to get around.";
                break;
            case 3:
                gameText.text = "I saw something using " + thisCryptid[1] + " to move.";
                break;
            case 4:
                gameText.text = "Yeah this big thing came through the other day and attacked " + thisCryptid[3] + ".";
                break;
            case 5:
                gameText.text = "This huge frickin monster came through here and attacked " + thisCryptid[3] + "!";
                break;
            default:
                break;
        }
    }

    public void chPress()
    {
        randomDialogue = Random.Range(0, 6);

        switch (randomDialogue)
        {
            case 0:
                gameText.text = "Yeah this really weird " + thisCryptid[2] + " creature came in here the other day.";
                break;
            case 1:
                gameText.text = "I saw this huge " + thisCryptid[2] + " creature in here the other day.";
                break;
            case 2:
                gameText.text = "There was this super weird thing using its  " + thisCryptid[1] + " to get around.";
                break;
            case 3:
                gameText.text = "I saw something using " + thisCryptid[1] + " to move.";
                break;
            case 4:
                gameText.text = "We're getting reports that the creature has been attacking " + thisCryptid[3] + ".";
                break;
            case 5:
                gameText.text = "Apparently the monster has been attacking " + thisCryptid[3] + "!";
                break;
            default:
                break;
        }

    }
}
