using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WinMenu : MonoBehaviour
{
    public Sprite[] cryptids; //0 Bigfoot, 1 Mothman, 2 Nessie, 3 The Nightcrawlers, 4 Frogman
    public Image cryptidPhoto; 

    public TextMeshProUGUI winText;

    public GameSystem thisGameSystem;
    public CryptidManager thisCryptidManager;

    void Update()
    {
        switch (thisCryptidManager.thisCryptid)
        {
            case "Mothman":
                cryptidPhoto.sprite = cryptids[1];
                break;
            case "Bigfoot":
                cryptidPhoto.sprite = cryptids[0];
                break;
            case "Nessie":
                cryptidPhoto.sprite = cryptids[2];
                break;
            case "The Nightcrawlers":
                cryptidPhoto.sprite = cryptids[3];
                break;
            case "Frogman":
                cryptidPhoto.sprite = cryptids[4];
                break;
            default:
                break;
        }

        winText.text = "Congratulations! You've discovered " + thisCryptidManager.thisCryptid + "! Nice photo...";

    }
}
