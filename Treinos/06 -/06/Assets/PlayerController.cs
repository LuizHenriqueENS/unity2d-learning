using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float xMoveSpeed = 0f;
    [SerializeField] float jumpForce = 3f;
    [SerializeField] Animator animator;
    Rigidbody2D rb;
    
    // Start is called before the first frame update
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

    private void Move()
    {
        
        float xMove = Input.GetAxis("Horizontal") * Time.deltaTime * xMoveSpeed;
        transform.position = new Vector2(transform.position.x + xMove, transform.position.y);
        animator.SetFloat("Speed", Mathf.Abs(xMove));

        
    }
    private void Jump()
    {
        var jump = Input.GetKeyDown(KeyCode.C);
        if (jump)
        {
        rb.velocity = new Vector2(0f, jumpForce);

        }
      
    }

}
