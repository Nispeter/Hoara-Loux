using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementController : AbstractGrid
{
    public Rigidbody2D rb; 

    void Start(){
        rb = GetComponent<Rigidbody2D>();
        Move();
    }

    void FixedUpdate()
    {
        CheckDeath();
    }

    public float movementSpeed = 2f;

    private void Move(){
        rb.velocity = -transform.up * movementSpeed;
    }

    private void CheckDeath(){
        if(transform.position.y < -6f){
             Destroy(gameObject);
        }
           
    }
}
