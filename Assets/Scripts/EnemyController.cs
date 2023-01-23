using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyController : HealthDamage
{
    private float scoreAdd;
    public GameObject temp;

    void Start()
    {
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

    public void setScoreAdd(float score){
        scoreAdd = score;
    }

    private void Hit(float damage){
        Health = Health - damage;
        print(Health);
    }

    public override void Defeat(){
        //PC.EnemyDefeated(scoreAdd);
        Destroy(gameObject);
    }
}
