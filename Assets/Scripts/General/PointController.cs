using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointController : MonoBehaviour
{
    public TextMeshProUGUI pointMesh;
    public TextMeshProUGUI highMesh;

    [SerializeField] private int scoreCounter = 0;
    [SerializeField] private int hScoreCounter = 0;
    
    private float timeElapsed = 0f;
    private float timeScoreRatio = 1f;

    private void Start(){
        hScoreCounter = getHighScore();
    }

    private void FixedUpdate (){
         UpdateScore();
    }

    private void UpdateScore(){
        timeElapsed++;
        float temp = timeElapsed/timeScoreRatio*Time.deltaTime;
        if(temp >= 1f){
            scoreCounter += 1;
            timeElapsed = 0;
        }
        DisplayBothScore();
    }

    public int GetScoreCounter(){
        return scoreCounter;
    }

    public int GetHScoreCounter(){
        return hScoreCounter;
    }

    public void EnemyDefeated(int score){
        scoreCounter += score;
    }

    public void addCore (int score){
        scoreCounter += score;
    }

    private int getHighScore(){
        return PlayerPrefs.GetInt("HighScore",0);
    }

    private void DisplayBothScore(){
        DisplayScore(pointMesh,scoreCounter);
        DisplayScore(highMesh,hScoreCounter,"HS = : ");
    }

    private void DisplayScore(TextMeshProUGUI mesh, int score , string s){
        mesh.text = s + score.ToString();
    }

    private void DisplayScore(TextMeshProUGUI mesh, int score){
        mesh.text = score.ToString();
    }

    private void SaveHS(){}
}
