using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Ninja : MonoBehaviour
{
    public float upForce = 250f;
    public bool isDead = false;

    private Rigidbody2D rb2d;
    private Animator anim;
    public AudioSource JumpSound;
    



	
	void Start ()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
	}
	
	
	void Update ()
    {
		if(isDead) { return; }
        if (Input.GetMouseButtonDown(0))
        {
            JumpSound.Play();
            rb2d.velocity = Vector2.zero;
            rb2d.AddForce(new Vector2(0, upForce));
            anim.SetTrigger("Flap");
        }
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        isDead = true;
        rb2d.velocity = Vector2.zero;
        anim.SetTrigger("Die");
        GameControl.instance.Die();
    }
}
