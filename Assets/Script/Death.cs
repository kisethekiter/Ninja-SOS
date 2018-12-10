using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour {

    public bool isDead = false;
    public float upForce = 0f;

    private Rigidbody2D rb2d;
	
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
	}
	
	
	void Update () {

        if (isDead) { return; }
        if (Input.GetKeyUp(0))
        {
            rb2d.velocity = Vector2.zero;
            rb2d.AddForce(new Vector2(0, upForce));
        }

   
	}


    private void OnCollisionEnter2D()
    {
        isDead = true;
        rb2d.velocity = Vector2.zero;
        GameControl.instance.Die();
    }
}
