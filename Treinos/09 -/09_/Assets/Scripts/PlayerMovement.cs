using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float xMove = 3f;
    [SerializeField] float jumpForce = 3f;
    [SerializeField] Collider2D isGrounded;
    [SerializeField] Animator animator;
    [SerializeField] SpriteRenderer sr;
    bool canJump = false;

    
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        JumpTheCharacter();
        Move();
    }
    private void Update()
    {
    }

    private void Move()
    {
        var horizontalMove = Input.GetAxis("Horizontal") * xMove * Time.deltaTime;
        if (horizontalMove > 0 || horizontalMove < 0)
        {
            rb.velocity = new Vector2(horizontalMove, rb.velocity.y);
            animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
        }
        FlipX(horizontalMove);
    }

    private void FlipX(float horizontalMove)
    {
        if (horizontalMove < 0)
        {
            sr.flipX = true;
        }
        if (horizontalMove > 0)
        {
            sr.flipX = false;
        }
    }

    private void JumpTheCharacter()
    {
        var theJumpButton = Input.GetAxis("Jump");
        if (theJumpButton > 0 && canJump == true)
        {
            rb.velocity = new Vector2(0f, jumpForce * Time.fixedDeltaTime);
            animator.SetBool("Jump", true);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.tag == "Plataforma")
        {
            animator.SetBool("Jump", false);
            canJump = true;
        } 
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        canJump = false;
    }
}

