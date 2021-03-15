using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CryptidManager : MonoBehaviour
{
    //these string arrays hold cryptid info
    public string[] mothman;
    public string[] bigfoot;
    public string[] nessie;

    public string[] cryptid; //this is the list of cryptids
    public string thisCryptid;

    // Start is called before the first frame update
    void Start()
    {
        thisCryptid = cryptid[Random.Range(0, 3)]; //this randomly assigns this round's cryptid        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
