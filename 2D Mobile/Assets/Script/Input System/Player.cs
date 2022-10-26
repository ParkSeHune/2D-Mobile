using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Player : MonoBehaviour
{
    [SerializeField] int health = 100;

    [SerializeField] SpriteRenderer sprite;
    [SerializeField] float speed = 10.0f;

    [SerializeField] Rigidbody2D rigidBody2D;
    [SerializeField] float jumpForce = 7.0f;


    int value = 0;
    [SerializeField] GameManager gameManager;

    private void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
    }

    public void Update()
    {
        if (transform.position.y <= -10)
        {
            transform.position = Vector2.zero;
        }
    }

    private void FixedUpdate()
    {
        Move();
    }

    public void Move()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        if (x > 0)
        {
            sprite.flipX = false;
        }
        else if (x < 0)
        {
            sprite.flipX = true;
        }

        transform.Translate(x * speed * Time.deltaTime, 0, transform.position.z);
    }

    public void OnClickJumpButton()
    {
        gameManager.Score = value++;

        Debug.Log(gameManager.Score);

        rigidBody2D.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);

        Handheld.Vibrate();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Portal"))
        {
            Camera.main.transform.position = new Vector3(-25, 0, -10);
            transform.position = new Vector3(-34.3f, -2.85f, 0);
        }

        if (collision.CompareTag("Posion"))
        {
            if (health < 100)
            {
                health += 10;
            }
            Debug.Log("Ãæµ¹");

            Destroy(collision.gameObject);
        }
    }
}
