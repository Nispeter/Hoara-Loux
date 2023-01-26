using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : HealthDamage
{
    public float hp = 10f;

    public GameObject bulletPrefab;
    
    public GameOverMenuController MC;
    
    public void Shoot(){
        
        Instantiate(bulletPrefab, gameObject.transform.position, gameObject.transform.rotation);
    }
    
    private void OnFire(){
        Shoot();
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Enemy"){
            Hit(other.gameObject.GetComponent<EnemyController>().damage);
        }  
    }

    public void Hit(float damage){
        print(damage);
        Health = Health - damage;
        print(Health);
    }

    public override void Defeat(){
        Destroy(gameObject);
        MC.GameOver();
    }
        
}
