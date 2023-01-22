using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyController : HealthDamage
{
    private float hp = 10f;
    void Start()
    {
        Health = hp;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Bullet")
            Hit(other.gameObject.GetComponent<FastBulletController>().bulletDamage);

    }

    private void Hit(float damage){
        Health = Health - damage;
        print(Health);
    }

    public override void Defeat(){
        Destroy(gameObject);
    }
}
