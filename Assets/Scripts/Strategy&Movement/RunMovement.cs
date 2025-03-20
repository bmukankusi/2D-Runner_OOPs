using UnityEngine;

public class RunMovement : IMovementStrategy
{
    public void Move(Rigidbody2D rb)
    {
        rb.velocity = new Vector2(5f, rb.velocity.y);
    }
}
