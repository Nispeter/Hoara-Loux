using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FastBulletController : MonoBehaviour
{
    [SerializeField] private float movementSpeed =  30f;
    public Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Move();
    }

    void FixedUpdate()
    {
        CheckDeath();
    }

    private void Move(){
        rb.velocity = transform.up * movementSpeed;
    }

    private void CheckDeath(){
        if(transform.position.y > 6f){
             Destroy(gameObject);
        }     
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Enemy")
            Destroy(gameObject);
    }

}
