using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public HealthDamage HD;
    public Image healthBar;

    [SerializeField] private float currentHealth;
    [SerializeField] private float maxHealth;

    private void Start(){
        //healthBar = GetComponent<Image>();
        maxHealth = HD.maxHealth;
    }

    private void Update(){
        currentHealth = HD.Health;
        healthBar.fillAmount = currentHealth/maxHealth;
    }
}
