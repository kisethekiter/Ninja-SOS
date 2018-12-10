using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackground : MonoBehaviour
{

    private BoxCollider2D groundCollider;
    private float groundhorizontalLength;


    void Start()
    {
        groundCollider = GetComponent<BoxCollider2D>();
        groundhorizontalLength = groundCollider.size.x;

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -groundhorizontalLength)
        {
            RepositionBackground();
        }

    }

    private void RepositionBackground()
    {
        Vector2 groundoffset = new Vector2(groundhorizontalLength * 2, 0);
        transform.position = (Vector2)transform.position + groundoffset;
    }

}



