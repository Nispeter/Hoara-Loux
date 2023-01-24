using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "PickUp", menuName = "Hoara Loux/PickUp", order = 0)]
public class PickUp : ScriptableObject {
    
    public new string name;
    public string perk;

    public Sprite artwork;

    public float speed;
    public int score;

    public PointController PC;
    private void OnTriggerEnter2D(Collider2D other) {}

}
