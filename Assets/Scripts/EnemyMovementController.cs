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
        
    }

    public float movementSpeed = .6f;

    private void Move(){
        Vector2 direction = (Vector3)(new Vector3(0,-1,0)).normalized;
        rb.AddForce(direction * movementSpeed * Time.deltaTime);
    }
}
