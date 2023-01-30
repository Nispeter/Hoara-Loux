using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitAnimationController : MonoBehaviour
{

    private CharacterAnimator CA;
    private SpriteRenderer spriteRenderer;
    public Animator _anim;

    public static readonly int Hit = Animator.StringToHash("HitAnimation");
    public static readonly int Idle = Animator.StringToHash("IdleAnim");

    private Material ogMaterial;
    private Material hitMaterial;

    private void Start(){
        CA = new CharacterAnimator();
        spriteRenderer = gameObject.GetComponentInChildren<SpriteRenderer>();
        _anim = gameObject.GetComponent<Animator>();
        ogMaterial = spriteRenderer.material;
        hitMaterial = (Material)Resources.Load("HitMaterial", typeof(Material));
    }

    public void HitAnimation(){
        _anim.CrossFade(Hit,CA.transitionTime,0);
    }

    public void Flash(){
        spriteRenderer.material = hitMaterial;
    }

    public void endFlashAnim(){
        stopFlash();
        _anim.CrossFade(Idle,CA.transitionTime,0);
    }

    public void stopFlash(){
        spriteRenderer.material = ogMaterial;
    }
}

internal class CharacterAnimator{
    [SerializeField] public int animationLayer = 0;
    [SerializeField] public float transitionTime  = 0f;    
}
