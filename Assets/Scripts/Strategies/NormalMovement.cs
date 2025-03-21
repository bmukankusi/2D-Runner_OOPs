using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalMovement : IMovementStrategy
{
    public void Move(PlayerController player, float moveInput, float moveSpeed)
    {
        player.GetComponent<Rigidbody2D>().velocity = new Vector2(moveInput * moveSpeed, player.GetComponent<Rigidbody2D>().velocity.y);
    // Error message in console
    Console.WriteLine("Player moving on ground");
    }
}
