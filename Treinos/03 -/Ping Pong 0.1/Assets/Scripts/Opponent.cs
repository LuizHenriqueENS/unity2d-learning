using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Opponent : MonoBehaviour
{

    [SerializeField] Ball ballPos;
    [SerializeField] float paddleVelocity = 10;


    // Cached Ref;
    Rigidbody2D rb;
    Ball ball;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ball = FindObjectOfType<Ball>();
    }

    private void FixedUpdate()
    {
        OpponentMove();
    }
    void OpponentMove()
    {
        Vector2 paddlePos = new Vector2(transform.position.x, transform.position.y);
        paddlePos.y = Mathf.Clamp(ballPos.transform.position.y - paddleVelocity, 0, 12);
        transform.position = paddlePos;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Bola")
        {
            ball.GetComponent<Rigidbody2D>().velocity = new Vector2(20f, Random.Range(-20f, 25f));
        }
    }
}
