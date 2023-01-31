using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : HealthDamage
{
    public float hp = 10f;
    public GameObject bulletPrefab;
    
    public GameOverMenuController MC;
    private HitAnimationController HAC;

    [SerializeField] private AudioSource ShootSE;
    [SerializeField] private AudioSource HitSE;

    private int ammoCounter = 3;
    private int maxAmmo = 3;
    private float reloadTime = 10f;

    private void Start(){
        HAC = GetComponent<HitAnimationController>();
    }

    private IEnumerator Reload(float interval){
        yield return new WaitForSeconds(interval);
    }

    public void Shoot(){
        if(ammoCounter > 0){
            ShootSE.Play();
            Instantiate(bulletPrefab, gameObject.transform.position, gameObject.transform.rotation);
            ammoCounter--;
        }
        else {
            Reload(reloadTime);
            ammoCounter = maxAmmo;
        }
        
    }
    
    private void OnFire(){
        Shoot();
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Enemy"){
            Hit(other.gameObject.GetComponent<EnemyController>().damage);
            HAC.HitAnimation();
        }  
    }

    public void Hit(float damage){
        HitSE.Play();
        Health = Health - damage;

    }

    public override void Defeat(){
        Destroy(gameObject);
        MC.GameOver();
    }
        
}
