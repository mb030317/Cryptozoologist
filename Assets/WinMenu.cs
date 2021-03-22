using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WinMenu : MonoBehaviour
{
    public Sprite[] cryptids; //0 Bigfoot, 1 Mothman, 2 Nessie
    public Image cryptidPhoto; 

    public TextMeshProUGUI winText;

    public GameSystem thisGameSystem;
    public CryptidManager thisCryptidManager;

    void Update()
    {
        switch (thisCryptidManager.thisCryptid)
        {
            case "Mothman":
                winText.text = "Congratulations! You've discovered " + thisCryptidManager.thisCryptid + "! Nice photo...";
                cryptidPhoto.sprite = cryptids[1];
                break;
            case "Bigfoot":
                winText.text = "Congratulations! You've discovered " + thisCryptidManager.thisCryptid + "! Nice photo...";
                cryptidPhoto.sprite = cryptids[0];
                break;
            case "Nessie":
                winText.text = "Congratulations! You've discovered " + thisCryptidManager.thisCryptid + "! Nice photo...";
                cryptidPhoto.sprite = cryptids[2];
                break;
            default:
                break;
        }
        
    }
}
