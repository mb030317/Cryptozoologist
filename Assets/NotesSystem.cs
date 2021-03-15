using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NotesSystem : MonoBehaviour
{
    public GameObject mainScreen;
    public GameObject noteScreen;
    public GameObject gameText;

    public GameSystem thisGameSystem;

    //grabs the various text objects on the note screen
    public TextMeshProUGUI movementText;
    public TextMeshProUGUI looksText;
    public TextMeshProUGUI attackingText;

    //these are used to put in the correct notes
    int movementInt;
    int looksInt;
    int attackingInt;

    void Start()
    {
        thisGameSystem = GetComponent<GameSystem>();
    }

    public void notePress()
    {
        noteScreen.SetActive(true);
        mainScreen.SetActive(false);
        gameText.SetActive(false);
    }

    public void backPress()
    {
        noteScreen.SetActive(false);
        mainScreen.SetActive(true);
        gameText.SetActive(true);

        thisGameSystem.resetMainText();
    }

    public void movementPress()
    {
        if(movementInt < 3) //cycles to the next option on button press
        {
            movementInt++;
        }

        else //resets the movement int to 0 once all options are cycled through
        {
            movementInt = 0;
        }


        switch (movementInt)
        {
            case 0:
                movementText.text = "Movement:";
                break;
            case 1:
                movementText.text = "Movement: Wings";
                break;
            case 2:
                movementText.text = "Movement: Legs";
                break;
            case 3:
                movementText.text = "Movement: Fins";
                break;
            default:
                break;
        }
    }

    public void looksPress()
    {
        if(looksInt < 3)
        {
            looksInt++;
        }

        else
        {
            looksInt = 0;
        }

        switch (looksInt)
        {
            case 0:
                looksText.text = "Looks:";
                break;
            case 1:
                looksText.text = "Looks: Fuzzy";
                break;
            case 2:
                looksText.text = "Looks: Furry";
                break;
            case 3:
                looksText.text = "Looks: Rubbery";
                break;
            default:
                break;
        }
    }

    public void attackingPress()
    {
        if(attackingInt < 3)
        {
            attackingInt++;
        }

        else
        {
            attackingInt = 0;
        }

        switch (attackingInt)
        {
            case 0:
                attackingText.text = "Attacking:";
                break;
            case 1:
                attackingText.text = "Attacking: People";
                break;
            case 2:
                attackingText.text = "Attacking: Animals";
                break;
            case 3:
                attackingText.text = "Attacking: Nobody";
                break;
            default:
                break;
        }
    }
}
