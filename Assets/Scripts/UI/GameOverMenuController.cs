using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenuController : PauseMenuController
{
    public GameObject gameOverCanvas;

    public void GameOver(){
        PauseGame();
        gameOverCanvas.SetActive(true);
    }

    public override void RetryGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
