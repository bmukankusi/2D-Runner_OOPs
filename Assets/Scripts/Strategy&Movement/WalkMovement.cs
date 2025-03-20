using UnityEngine;

public class WalkMovement : IMovementStrategy
{
    public void Move(Rigidbody2D rb)
    {
        rb.velocity = new Vector2(2f, rb.velocity.y);
    }
}
