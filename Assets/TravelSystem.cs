using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TravelSystem : MonoBehaviour
{
    public string[] locations;
    public string startingLocation;
    public string nextLocation;

    // Start is called before the first frame update
    void Start()
    {
        startingLocation = locations[Random.Range(0, 5)];
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
