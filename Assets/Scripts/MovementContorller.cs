using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovementContorller : AbstractGrid
{
    private void FixedUpdate(){
        flipSwap = columnCounter/2;
        upB = (columnCounter-1)/2;
        TryMove();
        lerpPos();
    }

    [SerializeField] private int movementCount = 1;
    
    [SerializeField] private bool lockInput = false;
    private Vector2 movementInput;

    private int loB = 0;
    private int upB = 2;

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
    private int flipSwap;
    
    private void OnFlip(){
        lockInput = true;
        
        if(!flipped){
            movementCount = columnCounter - movementCount ;
            loB += flipSwap;
            upB += flipSwap;
            flipped = true;
        }
        else{
            movementCount = columnCounter - movementCount;
            loB -= flipSwap;
            upB -= flipSwap;
            flipped = false;
        }
        if(movementCount > 0)movementCount--;
        else movementCount ++;
    }
}
