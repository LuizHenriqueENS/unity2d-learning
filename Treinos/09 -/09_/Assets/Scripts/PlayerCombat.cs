using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public Animator animator;
    [SerializeField] float strike2 = 2f;
    public SpriteRenderer sprite;
    Rigidbody2D rb;
    // Update is called once per frame

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
        animator.SetTrigger("Attack");
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            animator.SetTrigger("Attack2");

            if(sprite.flipX == true)
            {
            rb.velocity = new Vector2(-strike2, 0f);
            } else
            {
                rb.velocity = new Vector2(strike2, 0f);
            }
        }
    }
}
