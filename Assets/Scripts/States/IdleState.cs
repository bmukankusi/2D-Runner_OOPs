using UnityEngine;

public class IdleState : IPlayerState
{
    public void HandleInput(Player player)
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            player.SetState(new RunningState());
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            player.SetState(new JumpingState());
        }
    }

    public void UpdateState(Player player)
    {
        Debug.Log("Player is idle.");
    }
}
