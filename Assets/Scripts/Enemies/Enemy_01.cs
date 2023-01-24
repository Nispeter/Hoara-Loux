using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_01 : EnemyController
{
    public int score;

    void Start()
    {
        setScoreAdd(score);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
