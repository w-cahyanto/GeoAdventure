using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private Rigidbody2D rb;
    public float speed;
    private float keyX;

    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        keyX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(keyX * speed, rb.velocity.y);
    }
}
