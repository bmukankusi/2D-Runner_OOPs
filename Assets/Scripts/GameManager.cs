using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public Text lifeScoreText;
    public Text playerStateText;
    public Text winMessageText;
    public Text SpeedBoostedText;
    public GameObject celebrationEffect; //Particle system
    public Transform player;


    public int lifeScore = 100;

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

    public void ReduceLife(int amount)
    {
        lifeScore -= amount;
        UpdateLifeUI();

        if (lifeScore <= 0)
        {
            GameOver();
        }
    }

    private void UpdateLifeUI()
    {
        lifeScoreText.text = "Life: " + lifeScore;
        lifeScoreText.color = (lifeScore < 30) ? Color.red : Color.white;
    }

    private void GameOver()
    {
        winMessageText.text = "Game Over!";
        Time.timeScale = 0;  // Stops the game
        Application.Quit(); // Quits the game
    }

    public void DisplayWinMessage()
    {
        winMessageText.text = "Yay! You won!";
        celebrationEffect.SetActive(true); // Activate particles
        Instantiate(celebrationEffect, player.position, Quaternion.identity);

    }

    public void UpdatePlayerState(string state)
    {
        playerStateText.text = state;
    }

    public void DisplaySpeedBoostMessage(float duration)
    {
        SpeedBoostedText.gameObject.SetActive(true);
        Invoke("HideSpeedBoostMessage", duration);
        SpeedBoostedText.text = "Speed Boosted x 2!";
    }

    // Display celebration effect


}
