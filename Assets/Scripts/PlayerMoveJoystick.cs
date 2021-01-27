using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveJoystick : MonoBehaviour
{


    private float horizontalMove = 0f;
    private float verticalMove = 0f;

    public Joystick joystick;

    public float runSpeedHorizontal = 2;

    public float runSpeed = 1.25f;
    public float jumpSpeed = 3;

    public float doubleJumpSpeed = 100000000000f;

    private bool canDoubleJump;

    Rigidbody2D rb2D;

  

    public SpriteRenderer spriteRenderer;


    public Animator animator;



    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }


    private void Update()
    {


        if (horizontalMove>0)
        {


            spriteRenderer.flipX = false;

            animator.SetBool("Run", true);



        }
        else if (horizontalMove<0)
        {

            spriteRenderer.flipX = true;
            animator.SetBool("Run", true);



        }
        else
        {

            animator.SetBool("Run", false);


        }


        if (CheckGround.isGrounded == false)
        {
            animator.SetBool("Jump", true);
            animator.SetBool("Run", false);
        }
        if (CheckGround.isGrounded == true)
        {
            animator.SetBool("Jump", true);
        }

    }


    void FixedUpdate()
    {


        horizontalMove = joystick.Horizontal * runSpeedHorizontal;

        transform.position += new Vector3(horizontalMove,0,0) * Time.deltaTime * runSpeed;

        

 
    }


    public void Jump()
    {

        if (CheckGround.isGrounded)
        {

            canDoubleJump = true;
            rb2D.velocity = new Vector2(rb2D.velocity.x, jumpSpeed);


        }
        else
        {
 
                if (canDoubleJump)
                {
                    rb2D.velocity = new Vector2(rb2D.velocity.x, jumpSpeed);
                    canDoubleJump = false;

                }

            

        }

    }
}
