using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LogicScript : MonoBehaviour
{
    public GameObject candy;
    public int playerScore = 0;
    public Text scoreText;
    public Text highScoreText;

    public GameObject gameOverScreen;

    public candySpawnerScript candySpawn;
    public catMovementScript catMove;


    int highScore;

    public bool candyIsAlive = true;

    private void Start()
    {
        highScoreText.text = "High Score\t:  " + PlayerPrefs.GetInt("hiScore").ToString();
        //PlayerPrefs.SetInt("hiScore", 0);
        //PlayerPrefs.Save();

    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        //SceneManager.LoadScene(0);
    }

    public void stopGame()
    {
        Application.Quit();
        print("Quit is pressed");
    }


    [ContextMenu("add score")]
    public void addScore()
    {
        playerScore += 1;
        scoreText.text = "Score\t\t\t:  " + playerScore.ToString();
       


        if (PlayerPrefs.HasKey("hiScore"))
        {
            if (playerScore > PlayerPrefs.GetInt("hiScore"))
            {
                highScore = playerScore;
                PlayerPrefs.SetInt("hiScore", highScore);
                PlayerPrefs.Save();
            }
        }
        else
        {
            if (playerScore > highScore)
            {
                highScore = playerScore;
                PlayerPrefs.SetInt("hiScore", highScore);
                PlayerPrefs.Save();
            }
        }

        highScoreText.text = "High Score\t:  " + PlayerPrefs.GetInt("hiScore").ToString();



    }

    public void gameOver()
    {

        scoreText.text = "Score\t\t\t:  " + playerScore;
        highScoreText.text = "High Score\t:  " + PlayerPrefs.GetInt("hiScore").ToString();
        gameOverScreen.SetActive(true);
        //SceneManager.LoadScene(1);
        candySpawn.StopCoroutine("startSpawning");
        catMove.catCanMove = false;


    }

    public void gotoMainMenu()
    {
       

        SceneManager.LoadScene(0);
    }



}
