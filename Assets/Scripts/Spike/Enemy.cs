using System;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private IStrategy attackStrategy;

    private void Start()
    {
        attackStrategy = new SpikeDamage(); // Default strategy
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            attackStrategy.Execute(collision.GetComponent<Player>());
        }
    }
}
