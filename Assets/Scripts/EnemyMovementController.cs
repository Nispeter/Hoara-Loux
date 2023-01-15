using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementController : MonoBehaviour
{
    public Rigidbody2D rb;

    void Start(){
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        Move();
    }

    public float movementSpeed = 10f;

    private void Move(){
        Vector2 direction = (Vector2)(new Vector3(0,-1,0)).normalized;
        rb.AddForce(direction * movementSpeed * Time.deltaTime);
    }
}
