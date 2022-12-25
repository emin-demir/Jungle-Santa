using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseSelect : MonoBehaviour
{
    public int house = 0;

    void OnTriggerEnter2D(Collider2D col)
    {

        house = int.Parse(gameObject.name);
        
    }
    void OnTriggerExit2D(Collider2D col)
    {

        house = 0;
        
    }
}
