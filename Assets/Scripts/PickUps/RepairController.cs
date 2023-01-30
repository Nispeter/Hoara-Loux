using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepairController : EnemyMovementController
{
    public PickUp repair;
    public float heal;

    new void Start()
    {
        movementSpeed = repair.speed;
        base.Start();
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Player"){
            other.gameObject.GetComponent<PlayerController>().Health += heal;
            Implode();
        }
    } 
}
