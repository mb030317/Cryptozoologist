using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CryptidManager : MonoBehaviour
{
    //these string arrays hold cryptid info
    public string[] mothman;
    public string[] bigfoot;
    public string[] nessie;
    public string[] nightcrawler;
    public string[] frogman;

    public string[] cryptid; //this is the list of cryptids
    public string thisCryptid;

    AdvancementManager thisAdvancementManager;

    // Start is called before the first frame update
    void Start()
    {
        thisAdvancementManager = GameObject.Find("AdvancementManager").GetComponent<AdvancementManager>();

        switch (thisAdvancementManager.successfulHunts)
        {
            case 0:
                thisCryptid = cryptid[Random.Range(0, 3)]; //this randomly assigns this round's cryptid
                break;
            case 1:
                thisCryptid = cryptid[Random.Range(0, 4)]; //increases the cryptid pool with successfulHunts (Adds Nightcrawlers)
                break;
            case 2:
                thisCryptid = cryptid[Random.Range(0, 5)]; //increases the cryptid pool with successfulHunts (Adds Frogman)
                break;
            default:
                break;
        }
               
    }
}
