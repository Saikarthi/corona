using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class error : MonoBehaviour
{
    public float speed = 5f;
    public float jump = 8f;
    public Transform groundcheckpoint;
    public float radius;
    public LayerMask groundlayer;
    public float movement = 0f;
    public Rigidbody2D RigidBody;
    public bool istouchground;
    private bool flipright;

    void Start()
    {
        flipright = true;
    }


    void Update()
    {
        istouchground = Physics2D.OverlapCircle(groundcheckpoint.position, radius, groundlayer);
        movement = Input.GetAxis("Horizontal");
        if (movement != 0 )
        {

            RigidBody.velocity = new Vector2(movement * speed, RigidBody.velocity.y);
            flip(movement);
        }
        if (Input.GetButton("Jump") && istouchground)
        {
            RigidBody.velocity = new Vector2(RigidBody.velocity.x, jump);
        }
    }
    public void flip(float ha)
    {
        if (ha > 0 && !flipright || ha < 0 && flipright)
        {
            flipright = !flipright;
            Vector2 thescale = transform.localScale;
            thescale.x *= -1;
            transform.localScale = thescale;
        }
    }

}
