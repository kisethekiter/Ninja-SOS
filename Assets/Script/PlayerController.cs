using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed;
    public float jumpForce;
    private float moveInput;

    private Rigidbody2D rb;

    private bool facingright = true;


    private bool Isgrounded;
    public Transform groundcheck;
    public float checkradius;
    public LayerMask whatisground;
    


    private int extraJumps;
    public int extrajumpvalue;




    void Start()
    {
        extraJumps = extrajumpvalue;
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {

        Isgrounded = Physics2D.OverlapCircle(groundcheck.position, checkradius, whatisground);


        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        if (facingright == false && moveInput > 0)
        {
            flip();

        }
        else if (facingright == true && moveInput < 0)
        {
            flip();
        }
    }


    void flip()
    {
        facingright = !facingright;
        Vector3 scaler = transform.localScale;
        scaler.x *= -1;
        transform.localScale = scaler;
    }




    void Update()
    {
        if (Isgrounded == true)
        {
            extraJumps = extrajumpvalue;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) && extraJumps > 0)
        {
            rb.velocity = Vector2.up * jumpForce;
            extraJumps--;
        }else if (Input.GetKeyDown(KeyCode.UpArrow) && extraJumps == 0 && Isgrounded == true){
            rb.velocity = Vector2.up * jumpForce;

        }
    }
}
