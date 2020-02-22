using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D body;
    public float speed, jump;
    public UnityEngine.UI.Text scoreText;
    private int score;

    // Start is called before the first frame update
    void Start()
    {
        body = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        body.AddForce(new Vector2(Input.GetAxis("Horizontal") * speed, 0));
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Pickup"))
        {
            Destroy(collider.gameObject);
            score++;
            UpdateScore();
        }
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Floor"))
        {
            if (Input.GetAxisRaw("Vertical") == 1 || Input.GetAxisRaw("Jump") == 1)
            {
                body.AddForce(new Vector2(0, jump), ForceMode2D.Impulse);
            }
        }
    }

    void UpdateScore()
    {
        scoreText.text = "Score: " + score;
    }
}
