using UnityEngine;

public class move : MonoBehaviour
{
    public float Speed;
    public float DirectionX, DirectionY;
    Rigidbody2D rb;
    SpriteRenderer rb2;
    private bool facinfRight = true;
    void Update()
    {
        MoveAndJump();

    }
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb2 = GetComponent<SpriteRenderer>();
    }
    void MoveAndJump()
    {
        DirectionX = Input.GetAxis("Horizontal");
      // DirectionY = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(DirectionX * Speed, rb.velocity.y);
        if (facinfRight==false && DirectionX >0)
        {
            Flip();
        }
        if (facinfRight == true && DirectionX < 0)
        {
            Flip();
        }
    }

    void Flip()
    {
        facinfRight = !facinfRight;
        Vector3 scaler = transform.localScale;
        scaler.x *= -1;
        transform.localScale = scaler;
    }
}


