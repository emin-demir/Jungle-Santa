using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject scene_1;

    public GameObject mainMenu;
    public void SahneGecis()
    {
        mainMenu.gameObject.SetActive(false);
        scene_1.gameObject.SetActive(true);
    }


}
