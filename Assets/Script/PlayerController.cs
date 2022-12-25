using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float moveSpeed = 5f;
    
    [SerializeField]
    Rigidbody2D rb;

    [SerializeField]
    Animator animator;

    float timez;

    Vector2 movement;

    public AudioSource auid;

    public Envanter envanter;

    // Update is called once per frame
    void Update()
    {
         if(envanter.gameUpdate == true){
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", Mathf.Lerp(movement.x,1,0.3f));
        animator.SetFloat("Vertical", Mathf.Lerp(movement.y,1,0.3f));
        animator.SetFloat("Speed", movement.sqrMagnitude);

        if(movement.x == 1 || movement.x == -1 || movement.y == 1 || movement.y == -1)
        {
            timez+= 0.7f;
            if(timez >= 100f)
            {
                auid.Play();
                timez = 0f;
            }

        }
       }
    }
    void FixedUpdate()
    {
        if(envanter.gameUpdate == true){
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
         }
    }

}
