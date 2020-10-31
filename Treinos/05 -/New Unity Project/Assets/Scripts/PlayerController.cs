using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float xVelocity = 10f;
    public Animator animator;
    bool flip = false;


    SpriteRenderer sr;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    private void FixedUpdate()
    {
        var xMove = Input.GetAxis("Horizontal") * Time.deltaTime * xVelocity;
        transform.position = new Vector2(xMove + transform.position.x, transform.position.y);
        animator.SetFloat("Speed", Mathf.Abs(xMove));
 
        if(xMove < 0)
        {
            sr.flipX = true;
        } 
        if (xMove > 0)
        {
            sr.flipX = false;
        }
    }
}
