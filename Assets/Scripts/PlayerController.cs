using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : HealthDamage
{
    public float hp = 10f;
    void Start()
    {
        Health = hp;
    }

    private void FixedUpdate(){}


    public GameObject bulletPrefab;
    
    public void Shoot(){
        
        Instantiate(bulletPrefab, gameObject.transform.position, gameObject.transform.rotation);
    }
    
    private void OnFire(){
        Shoot();
    }

    
        
}
