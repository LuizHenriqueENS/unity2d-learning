using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class PaddleMovement : MonoBehaviour
{

    [SerializeField] int speed = 15;
    [SerializeField] float minY = 2f;
    [SerializeField] float maxY = 10f;
    [SerializeField] float screenUnity = 10f;
    [SerializeField] Ball bola;

    Ball ball;

    void Start()
    {
        ball = FindObjectOfType<Ball>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        Movement();
    }

    private void Movement()
    {
        // moviment of paddle
        float v = Input.GetAxisRaw("Vertical");
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, v) * speed;

        // restriction of paddle in scene
        Vector2 paddlePos = transform.position;
        paddlePos.y = Mathf.Clamp(paddlePos.y, minY, maxY);
        transform.position = paddlePos;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Bola")
        {
            ball.GetComponent<Rigidbody2D>().velocity = new Vector2(20f, Random.Range(-20f, 25f));
        }
    }
}
