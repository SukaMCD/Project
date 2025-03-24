using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5;
    public Rigidbody2D rb;
    public Animator anim;

    void FixedUpdate ()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        anim.SetFloat("horizontal", horizontal);
        anim.SetFloat("vertical", vertical);

        rb.linearVelocity = new Vector2 (horizontal, vertical) * speed;
    }
}
