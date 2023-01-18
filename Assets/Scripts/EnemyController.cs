using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyController : HealthDamage
{
    public float hp = 10f;
    void Start()
    {
        Health = hp;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
