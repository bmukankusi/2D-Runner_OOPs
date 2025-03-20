using System;
using UnityEngine;

public class SpikeDamage : IStrategy
{
    public void Execute(Player player)
    {
        GameManager.Instance.ReduceLife(10);
    }
}
