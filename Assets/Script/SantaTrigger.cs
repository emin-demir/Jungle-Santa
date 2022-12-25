using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SantaTrigger : MonoBehaviour
{
    public GameObject houseTrigger;
    void OnTriggerEnter2D(Collider2D col)
    {
        houseTrigger.SetActive(true);
    }
}
