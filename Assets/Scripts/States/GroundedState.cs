using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundedState : IPlayerState
{
    public void Handle(PlayerController player)
    {
        GameManager.Instance.UpdatePlayerState("Player moving on ground");
    }
}
