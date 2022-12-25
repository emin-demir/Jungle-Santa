using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewDogFollow : MonoBehaviour
{
    [SerializeField]
    GameObject  Target;

    Animator anim;
    private float speed = 3f ;

    private float distance;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector2.Distance(transform.position,Target.transform.position);

        if(distance > 2){
            transform.position = Vector2.MoveTowards(transform.position, Target.transform.position,speed * Time.deltaTime);
            anim.SetBool("WalkDog",true);
        }
        else{
            anim.SetBool("WalkDog",false);
        }

        if(transform.position.x > Target.transform.position.x)
        {
            transform.GetComponent<SpriteRenderer>().flipX = true;
        }
        else{
            transform.GetComponent<SpriteRenderer>().flipX = false;
        }

    }
}
