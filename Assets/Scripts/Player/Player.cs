using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    private IPlayerState currentState;
    public float speed = 5f;
    public float jumpForce = 7f;
    private int jumpCount = 0;  // Track number of jumps
    private bool isGrounded = true;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        SetState(new IdleState());
    }

    private void Update()
    {
        currentState.HandleInput(this);
        currentState.UpdateState(this);
    }

    public void SetState(IPlayerState newState)
    {
        currentState = newState;
    }

    public bool IsGrounded()
    {
        return isGrounded;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            jumpCount = 0;  // Reset jumps when touching the ground
        }
    }

    public void Jump()
    {
        if (jumpCount < 2) // Allow two jumps
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            jumpCount++;
            isGrounded = false;
        }
    }
}
