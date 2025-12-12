using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class logicmanegerscript : MonoBehaviour
{
    public int playerScore;
    public Text scoreTexte;
    public GameObject gameOverScreen;

    [ContextMenu("Increse Score")]

    public void addScore()
    {
        playerScore = playerScore + 1;
        scoreTexte.text = playerScore.ToString();
    }

    public void resetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }

}


