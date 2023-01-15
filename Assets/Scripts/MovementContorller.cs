using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovementContorller : MonoBehaviour
{

    private void FixedUpdate(){
        TryMove();
        lerpPos();
    }

    private float[] fixedPositions = {-1.8f, -.8f, .8f, 1.8f};
    [SerializeField] private int movementCount = 1;
    
    [SerializeField] private bool lockInput = false;
    private Vector2 movementInput;

    private int loB = 0;
    private int upB = 1;

    private void TryMove(){
        if(movementInput != Vector2.zero && !lockInput){
            if(movementInput.x > 0 && movementCount < upB){  
                movementCount++;
            }
            else if (movementInput.x < 0 && movementCount > loB){
                movementCount--;
            }
            lockInput = true;  
        }
        else if(movementInput == Vector2.zero)
            lockInput = false;
    }

    private float transitionDuration = .08f;
    [SerializeField] private float elapsedTime = 0f;

    private void lerpPos(){

        Transform tempTrans = gameObject.transform;
        Vector3 targetPosition = new Vector3(fixedPositions[movementCount],tempTrans.position.y,0);

        if(tempTrans.position != targetPosition){
            elapsedTime += Time.deltaTime;
            float lerpRatio = elapsedTime/transitionDuration;
            transform.position = Vector3.Lerp(tempTrans.position, targetPosition, lerpRatio);
            lockInput = true;
        }
        else {
            elapsedTime = 0f;
            lockInput = false;
        }
       
    }

    private void OnMove(InputValue movementValue){                  
        movementInput = movementValue.Get<Vector2>();
    }

    bool flipped = false;
    
    private void OnFlip(){
        lockInput = true;
        if(!flipped){
            (fixedPositions[1], fixedPositions[3]) = (fixedPositions[3], fixedPositions[1]);
            (fixedPositions[0], fixedPositions[2]) = (fixedPositions[2], fixedPositions[0]);
            flipped = true;
        }
        else{
            (fixedPositions[3], fixedPositions[1]) = (fixedPositions[1], fixedPositions[3]);
            (fixedPositions[2], fixedPositions[0]) = (fixedPositions[0], fixedPositions[2]);
            flipped = false;
        }
        if(movementCount > 0)movementCount--;
        else movementCount ++;
    }
}
