using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{

    public CharacterController2D char1;

    public float runspeed = 40f;

    float horizontalmove = 0f;
    bool jump = false;

    // Update is called once per frame
    void Update()
    {
        horizontalmove = Input.GetAxisRaw("Horizontal") * runspeed;
        if(Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
    }


    void FixedUpdate()
    {
        char1.Move(horizontalmove * Time.fixedDeltaTime, false, jump);
        jump = false;

    }
}
