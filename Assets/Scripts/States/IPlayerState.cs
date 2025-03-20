using System;
using UnityEngine;


public interface IPlayerState
{
    void HandleInput(Player player);
    void UpdateState(Player player);
}
