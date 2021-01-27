using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{


    public float runSpeed=2;
    public float jumpSpeed = 3;

    public float doubleJumpSpeed = 2.5f;

    private bool canDoubleJump;

    Rigidbody2D rb2D;

    public bool betterJump = false;
    public float fallMultiplier = 0.5f;
    public float lowJumpMultiplier = 1f;

    public SpriteRenderer spriteRenderer;
    public GameObject sonidoSalto;

    public Animator animator;



    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }


    private void Update()
    {
        if (Input.GetKey("space"))
        {

            if (CheckGround.isGrounded)
            {

                canDoubleJump = true;
                rb2D.velocity = new Vector2(rb2D.velocity.x, jumpSpeed);
                Instantiate(sonidoSalto);

            }
            else
            {
                if (Input.GetKeyDown("space")) {
                    if (canDoubleJump)
                    {
                        rb2D.velocity = new Vector2(rb2D.velocity.x, jumpSpeed);
                        Instantiate(sonidoSalto);
                        canDoubleJump = false;

                    }

                }

            }
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
        if (Input.GetKey("d") || Input.GetKey("right"))
        {

            rb2D.velocity = new Vector2(runSpeed, rb2D.velocity.y);

            spriteRenderer.flipX = false;

            animator.SetBool("Run", true);



        }
        else if (Input.GetKey("a") || Input.GetKey("left"))
        {


            rb2D.velocity = new Vector2(-runSpeed, rb2D.velocity.y);
            spriteRenderer.flipX = true;
            animator.SetBool("Run", true);



        }
        else
        {

            rb2D.velocity = new Vector2(0, rb2D.velocity.y);
            animator.SetBool("Run", false);


        }

        if (betterJump) {
            if (rb2D.velocity.y<0) 
            {
                rb2D.velocity += Vector2.up * Physics2D.gravity * (fallMultiplier) * Time.deltaTime;

            }
            if (rb2D.velocity.y > 0 && !Input.GetKey("space")) {

                rb2D.velocity += Vector2.up * Physics2D.gravity * (lowJumpMultiplier) * Time.deltaTime;

            }
        }
    }
}
