using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJumpAndSit : MonoBehaviour
{
    private bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;
    private bool isUp;
    public Transform upCheck;
    public float checkRadiusup;
    public LayerMask whatIsUp;
    public bool crouching = false;
    public CircleCollider2D cirkle;
    Rigidbody2D rb;
    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);
        isUp = Physics2D.OverlapCircle(upCheck.position, checkRadiusup, whatIsUp);
        Sit();
        Jump();
    }
    private void Sit()
    {
        if (Input.GetKeyDown(KeyCode.C) && crouching == false && isGrounded)
        {
            animator.SetBool("Sit", true);
            cirkle.enabled = false;
            crouching = true;
        }
        else if (Input.GetKeyDown(KeyCode.C) && crouching == true && isUp == false )
        {
            animator.SetBool("Sit", false);
            cirkle.enabled = true;
            crouching = false;
        }
    }
    private void Jump()
    {
        if (isGrounded && Input.GetKeyDown(KeyCode.Space) && !crouching)
        {
            animator.SetTrigger("Jump");
            rb.AddForce(Vector2.up * Data.JumpForce, ForceMode2D.Impulse);
        }
    }
}
