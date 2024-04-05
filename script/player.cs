using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public SpriteRenderer sr;
    public Rigidbody2D rb;
    public float Speed=0.5f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }
    public float DirectionX, DirectionY;
    void MoveAndJump()
    {
        DirectionX = Input.GetAxis("Horizontal");
        DirectionY = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(DirectionX, DirectionY);
        transform.Translate(movement * Speed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isGround == true)
            {
                rb.AddForce(Vector2.up * 5f, ForceMode2D.Impulse);
                isGround = false;
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        MoveAndJump();
    }
    public bool isGround;
    public void OnCollisionEnter2D (Collision2D collision) 
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGround = true;
        }
    }
    private void OnCollisionExit2D (Collision2D collision)
    {

        if (collision.gameObject.tag == "Ground")
        {
            isGround = false;
        }
    }
}
