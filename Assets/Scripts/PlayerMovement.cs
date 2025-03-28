using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5;
    public int facingDirection = 1;
    public Rigidbody2D rb;
    public Animator anim;

    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Mengatur animasi gerakan
        anim.SetFloat("horizontal", Mathf.Abs(horizontal));
        anim.SetFloat("vertical", Mathf.Abs(vertical));

        // Menggerakkan pemain
        rb.linearVelocity = new Vector2(horizontal, vertical) * speed;

        // Membalik arah berdasarkan input horizontal
        if ((horizontal > 0 && facingDirection < 0) || (horizontal < 0 && facingDirection > 0))
        {
            Flip();
        }
    }

    void Flip()
    {
        facingDirection *= -1;
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }
}
