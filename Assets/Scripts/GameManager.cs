using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public int playerLife = 100;
    public Text lifeText;
    public GameObject winMessage;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void ReduceLife(int damage)
    {
        playerLife -= damage;
        lifeText.text = "Life: " + playerLife;

        if (playerLife <= 0)
        {
            Debug.Log("Game Over!");
        }
    }

    public void WinGame()
    {
        winMessage.SetActive(true);
        Debug.Log("You Win!");
    }
}
