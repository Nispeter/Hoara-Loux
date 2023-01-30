using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayUIController : MonoBehaviour
{

    public GameObject player;
    private PlayerController PC;
    private MovementContorller MC;

    [SerializeField] private Vector2 movementInput;

    private void Start(){
        PC = player.GetComponent<PlayerController>();
        MC = player.GetComponent<MovementContorller>();
    }

    public void LeftButton(){
        movementInput = new Vector2 (-1,0);
        MC.SetMovementInput(movementInput);
    }

    public void RightButton(){
        movementInput = new Vector2 (1,0);
        MC.SetMovementInput(movementInput);
    }

    public void Teleport(){
        MC.Flip();
    }

    public void Fire(){
        PC.Shoot();
    }

}
