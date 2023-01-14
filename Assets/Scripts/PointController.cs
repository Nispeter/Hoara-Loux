using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointController : MonoBehaviour
{
    public TextMeshProUGUI pointMesh;
    public TextMeshProUGUI highMesh;

    [SerializeField] private float scoreCounter = 0f;
    [SerializeField] private float hScoreCounter = 0f;
    
    private float timeElapsed = 0f;
    private float timeScoreRatio = 1f;

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

    private void DisplayBothScore(){
        DisplayScore(pointMesh,scoreCounter);
        //DisplayScore(highMesh,hScoreCounter,"HS=:");
    }

    private void DisplayScore(TextMeshProUGUI mesh, float score , string s){
        pointMesh.text = s + score.ToString();
    }

     private void DisplayScore(TextMeshProUGUI mesh, float score){
        pointMesh.text = score.ToString();
    }
}
