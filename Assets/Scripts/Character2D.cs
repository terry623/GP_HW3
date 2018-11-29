using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character2D : MonoBehaviour
{
    private float maxSpeed = 4.0f;
    private float jumpForce = 200.0f;
    private bool airControl = true;
    bool facingRight;

    public LayerMask groundLayer;
    Transform groundCheck;
    float groundRadius;
    bool onGround;

    Animator anim;

    void Awake()
    {
        groundCheck = transform.Find("GroundCheck");
        anim = GetComponent<Animator>();
    }

    void Start()
    {
        facingRight = true;
        groundRadius = 0.1f;
        onGround = false;
    }

    void FixedUpdate()
    {
        onGround = Physics2D.OverlapCircle(groundCheck.position, groundRadius, groundLayer);
        anim.SetBool("onGround", onGround);
        anim.SetBool("Attack", false);
    }

    public void Move(float movingSpeed, bool jump)
    {
        if (onGround || airControl)
        {
            anim.SetFloat("Speed", Mathf.Abs(movingSpeed));
            GetComponent<Rigidbody2D>().velocity = new Vector2(movingSpeed * maxSpeed, GetComponent<Rigidbody2D>().velocity.y);
            if (movingSpeed > 0 && !facingRight || movingSpeed < 0 && facingRight) Flip();
        }

        if (onGround && jump)
        {
            anim.SetBool("onGround", false);
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0.0f, jumpForce));
        }
    }

    public void Attack()
    {
        anim.SetBool("Attack", true);
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 characterScale = transform.localScale;
        characterScale.x *= -1;
        transform.localScale = characterScale;
    }

}
