using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyController : HealthDamage
{
    private int scoreAdd;
    private PointController PC;

    public float damage;

    [SerializeField] private AudioSource hitSE;
    [SerializeField] private AudioSource defeatSE;

    void Start()
    {
        
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
        PC = GameObject.Find("ScoreComponents").GetComponent<PointController>();
    }

    private void Hit(float damage){
        hitSE.Play();
        Health = Health - damage;
    }

    public override void Defeat(){
        hitSE.Play();
        PC.EnemyDefeated(scoreAdd);
        Destroy(gameObject);
    }
}
