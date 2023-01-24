using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : EnemyMovementController
{
    public PickUp coin;
    new void Start()
    {
        movementSpeed = coin.speed;
        base.Start();
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Player"){
            coin.PC = GameObject.Find("ScoreCanvas").GetComponent<PointController>();
            coin.PC.addCore(coin.score);
            Implode();
        }
    }   
    
}
