using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Player player;

    public void SetIdle()
    {
        if (player != null)
            player.SetState(new IdleState());
    }

    public void SetRunning()
    {
        if (player != null)
            player.SetState(new RunningState());
    }

    public void SetJumping()
    {
        if (player != null)
            player.SetState(new JumpingState());
    }
}
