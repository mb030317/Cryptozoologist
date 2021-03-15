using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExploreSystem : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject exploreMenu;

    public void explorePress()
    {
        mainMenu.SetActive(false);
        exploreMenu.SetActive(true);
    }
}
