using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2D : MonoBehaviour
{
	//for A&D  /  Right&Left Arrow And Jump Movement
    //for Adding W&S Movement, Remove The Slashes Below And Add Slashes 
    //To Jump Movement Only Also In RigidBody2D Remove Gravity For It
    
    public Rigidbody2D rb;
    private bool IsGrounded = true;
    private float MoveX;
    //private float MoveY;
    public float jumpPower;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetButtonDown("Jump") && IsGrounded)
        {            
            rb.AddForce(new Vector2(0,jumpPower));
            IsGrounded = false;
        }

        MoveX = Input.GetAxisRaw("Horizontal");
        // Remove The Slashes For W&S Movement Only
        //MoveY = Input.GetAxisRaw("Vertical");
        //Slash The Below Line Out For W&S Movement Only
        
        rb.AddForce(new Vector2(MoveX * 20, 0));
        //Remove The Slashes For W&S Movement Only
        
        //rb.velocity = (new Vector2(MoveX * 20, MoveY * 20));
        
        
    }
    public void OnTriggerEnter2D(Collider2D ob)
    {

    }
    public void OnCollisionEnter2D()
    {
        IsGrounded = true;
    }
}