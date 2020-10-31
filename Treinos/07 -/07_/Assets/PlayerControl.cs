using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    [SerializeField] float xMoveSpeed = 3f;
    [SerializeField] float jumpForce = 10f;


    bool isGrounded = false;
    public Transform isGroundedChecker;
    public float checkGroundRadius;
    public LayerMask groundLayer;
    public float rememberGroundedFor;
    float lastTimeGrounded;

    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Jump();
        Move();
        CheckIfGrounded();

    }

    private void Move()
    {
        var xMove = Input.GetAxis("Horizontal") * xMoveSpeed * Time.deltaTime;
        rb.velocity = new Vector2(xMove, rb.velocity.y);
    }

    private void Jump()
    {
        var jump = Input.GetAxis("Jump") * jumpForce;
        if (isGrounded || Time.time - lastTimeGrounded <= rememberGroundedFor)
        {
            rb.velocity = new Vector2(transform.position.x, jump);

        }


    }

    void CheckIfGrounded()
    {
        Collider2D collider = Physics2D.OverlapCircle(isGroundedChecker.position, checkGroundRadius, groundLayer);

        if (collider != null)
        {
            isGrounded = true;
        }
        else
        {
            if (isGrounded)
            {
                lastTimeGrounded = Time.time;
            }
            isGrounded = false;
        }
    }
}
