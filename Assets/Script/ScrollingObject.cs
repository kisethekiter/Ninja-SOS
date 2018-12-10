using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject : MonoBehaviour {


    private Rigidbody2D rb2d;


	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        //print("Scroll speed in use" + gameObject.name + " " + GameControl.instance.scrollSpeed);
        rb2d.velocity = new Vector2(GameControl.instance.scrollSpeed, 0);
	}
	
	void Update () {
		if(GameControl.instance.isGameOver)
        {
            rb2d.velocity = Vector2.zero;
        }
	}

    public void ChangeSpeed()
    {
        rb2d.velocity = new Vector2(GameControl.instance.scrollSpeed, 0);
        print("faster?");
    }
}
