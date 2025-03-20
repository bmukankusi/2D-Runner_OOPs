using UnityEngine;

public class RunningState : IPlayerState
{
    public void HandleInput(Player player)
    {
        if (Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.LeftArrow))
        {
            player.SetState(new IdleState());
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            player.SetState(new JumpingState());
        }
    }

    public void UpdateState(Player player)
    {
        Debug.Log("Player is running.");

        float moveDirection = 0;

        if (Input.GetKey(KeyCode.RightArrow))
        {
            moveDirection = 1;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            moveDirection = -1;
        }

        player.transform.Translate(Vector2.right * moveDirection * player.speed * Time.deltaTime);
    }
}
