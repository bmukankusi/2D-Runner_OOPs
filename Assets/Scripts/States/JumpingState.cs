using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpingState : IPlayerState
{
    public void Handle(PlayerController player)
    {
        GameManager.Instance.UpdatePlayerState("Player jumping");
    }
}
