using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Envanter : MonoBehaviour
{
    [SerializeField]
    GameObject gameO;

    [SerializeField]
    public bool gameUpdate = true;

    private float timeCount = 0;
    private float gecensure = 0.5f;


    void Update()
    {   

        if(Input.GetKey(KeyCode.E) &&  Time.time >= timeCount + gecensure)
        {
            timeCount = Time.time;
            gameO.SetActive(gameUpdate);
            gameUpdate = !gameUpdate;
        }



        // if(Input.GetKey(KeyCode.E))
        // {
        //     basildiMi = true;
        // }


        // if(basildiMi)
        // {
        //     gameO.SetActive(true);
        //     basildiMi = false;
        // }

        // else{
        //         gameO.SetActive(false)
        // }





        
    }
}
