using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] float jumpForce;
    [SerializeField] Animator animator;
    [SerializeField] SpriteRenderer spriteRenderer;
    public bool canIJump = true;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();    
        Jump();
    }

private void Move(){
    float inputMoveX = Input.GetAxis("Horizontal") * moveSpeed * Time.fixedDeltaTime;

    if(inputMoveX > 0 || inputMoveX < 0){
    rb.velocity = new Vector2 (inputMoveX, rb.velocity.y);
    animator.SetFloat("Speed", Mathf.Abs(inputMoveX));

    }

    if( inputMoveX > 0){
        spriteRenderer.flipX = false;
    } 
    if (inputMoveX < 0){
        spriteRenderer.flipX = true;
    }
}

private void Jump(){
    float jumpInput = Input.GetAxis("Jump") * jumpForce * Time.fixedDeltaTime;
    if (jumpInput > 0 && canIJump == true){
        animator.SetBool("Jump", true);
        rb.velocity = new Vector2 (rb.velocity.x, jumpInput);
        canIJump = false;
    }
}

private void OnTriggerStay2D(Collider2D collision){
    if(collision.tag == "Plataforma"){
    canIJump = true;
    animator.SetBool("Jump", false);
    
    }
}
    public bool PodePular()
    {
        return canIJump;
    }
}
