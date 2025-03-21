using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoostMovement : IMovementStrategy
{
    public void Move(PlayerController player, float moveInput, float moveSpeed)
    {
        player.GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed * 2 * moveInput, player.GetComponent<Rigidbody2D>().velocity.y);
    }

}
