using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float normalSpeed = 5f;
    public float jumpForce = 7f;
    public float boostedSpeed = 10f; // Speed boost
    private float moveSpeed;
    private bool isGrounded;
    private int jumpCount = 0;
    private Rigidbody2D rb;

    private IPlayerState playerState;
    private IMovementStrategy movementStrategy;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playerState = new GroundedState();
        movementStrategy = new NormalMovement();
        moveSpeed = normalSpeed;
    }

    void Update()
    {
        HandleMovement();
        HandleJump();
    }

    private void HandleMovement()
    {
        float moveInput = Input.GetAxisRaw("Horizontal"); // Supports Arrow Keys & A/D
        movementStrategy.Move(this, moveInput, moveSpeed);

        if (moveInput != 0)
        {
            playerState = new GroundedState();
            playerState.Handle(this);
        }
    }

    private void HandleJump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isGrounded || jumpCount < 2) 
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpForce);
                jumpCount++;
                playerState = new JumpingState();
                playerState.Handle(this);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            jumpCount = 0; // Reset double jump
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Spike"))
        {
            GameManager.Instance.ReduceLife(5);
        }
        else if (collision.gameObject.CompareTag("SpeedIncreaser"))
        {
            movementStrategy = new SpeedBoostMovement();
            moveSpeed = boostedSpeed; // Increase speed
            playerState = new SpeedingState();
            playerState.Handle(this);
            GameManager.Instance.DisplaySpeedBoostMessage(4);// Display Speed Boost message for four seconds



            Destroy(collision.gameObject); // Remove Speed Increaser after collection
        }
        else if (collision.gameObject.CompareTag("Flag"))
        {
            GameManager.Instance.DisplayWinMessage();
            
        }
    }
}
