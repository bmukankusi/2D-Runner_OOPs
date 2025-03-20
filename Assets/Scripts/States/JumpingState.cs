using UnityEngine;

public class JumpingState : IPlayerState
{
    public void HandleInput(Player player)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            player.Jump();
        }

        if (player.IsGrounded())
        {
            player.SetState(new IdleState());
        }
    }

    public void UpdateState(Player player)
    {
        Debug.Log("Player is jumping.");
    }
}
