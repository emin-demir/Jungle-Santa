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

    public static int slotCount = 13;

    public static GameObject gameOver;

    public GameObject gameOver2;

    public static Animator anim;
    public  Animator anim2;

void Start()
    {
        anim = anim2;
        gameOver = gameOver2;

    }
    
    void Update()
    {   

        if(Input.GetKey(KeyCode.E) &&  Time.time >= timeCount + gecensure)
        {
            timeCount = Time.time;
            gameO.SetActive(gameUpdate);
            gameUpdate = !gameUpdate;
        }
        if(slotCount == 0)
        {
            gameOver2.SetActive(true);
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
