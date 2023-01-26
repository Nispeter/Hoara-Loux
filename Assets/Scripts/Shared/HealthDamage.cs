using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthDamage : MonoBehaviour
{
    [SerializeField] private float health;
    public float maxHealth;

    public float Health{
        set{
            if(value > maxHealth){
                health = maxHealth;
            }
            else
                health = value;
            if(health <= 0)
                Defeat();
        }  
        get {
            return health;
        } 
    }

    public void  OnHit(){}

    public virtual void Defeat(){}
}
