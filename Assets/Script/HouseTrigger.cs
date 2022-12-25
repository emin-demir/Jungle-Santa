using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HouseTrigger : MonoBehaviour
{
    public Animator anim;
    public GameObject panel;
    void Start()
    {
    }
    void OnTriggerStay2D(Collider2D col)
        {
            if(col.name == "Player")
            {
            panel.SetActive(true);
            anim.SetBool("OpenPan",true);
            }
        }
    void OnTriggerExit2D(Collider2D col)
        {
            panel.SetActive(false);
        }


}
