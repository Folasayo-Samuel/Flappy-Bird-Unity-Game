using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public AudioClip gameOverClip; 

    private AudioSource audioSource;
    private bool audioPlayed = false;

void Start()
    {
        // Get or add AudioSource
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
            audioSource = gameObject.AddComponent<AudioSource>();

        audioSource.playOnAwake = false;
    }
    
    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore = playerScore + scoreToAdd;
        scoreText.text =  playerScore.ToString();
    }
    
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
    
    public void gameOver()
    {
    // Show Game Over UI
        if (gameOverScreen != null)
            gameOverScreen.SetActive(true);

        // Play sound once
        if (!audioPlayed && gameOverClip != null)
        {
            audioPlayed = true;
            audioSource.PlayOneShot(gameOverClip);
        }
        else if (gameOverClip == null)
        {
            Debug.LogWarning("gameOverClip not assigned!");
        }
    }
        // gameOverScreen.SetActive(true);

}
