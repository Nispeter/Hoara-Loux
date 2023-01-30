using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenuController : PauseMenuController
{
    public GameObject gameOverCanvas;
    public PointController pointController;

    public void GameOver(){
        PauseGame();
        gameOverCanvas.SetActive(true);
        checkSave();
    }

    public override void RetryGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void checkSave(){
        int tempScore = pointController.GetScoreCounter();
        int tempHScore = pointController.GetHScoreCounter();
        if(tempScore > tempHScore)
            SaveHighScore(tempScore);
    }

    private void SaveHighScore(int score){
        PlayerPrefs.SetInt("HighScore", score);
    }
}
