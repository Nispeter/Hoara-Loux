using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyController : HealthDamage
{
    private int scoreAdd;
    private PointController PC;

    public float damage;

    void Start()
    {
        damage = 2f;
        //sPC = temp.GetComponent<PointController>();
        //PC = GameObject.Find("ScoreCanvas").GetComponent<PointController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Bullet")
            Hit(other.gameObject.GetComponent<FastBulletController>().bulletDamage);

    }

    public void setScoreAdd(int score){
        scoreAdd = score;
        PC = GameObject.Find("ScoreCanvas").GetComponent<PointController>();
    }

    private void Hit(float damage){
        Health = Health - damage;
    }

    public override void Defeat(){
        PC.EnemyDefeated(scoreAdd);
        Destroy(gameObject);
    }
}
