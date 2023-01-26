// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.InputSystem;  

// public class SwipeInput : MonoBehaviour
// {
//     // minimum distance for a swipe to be registered
//     public float swipeDistance = 20f;
//     public GameObject player;

//     // starting position of the touch
//     private Vector2 startPos;
//     // current position of the touch
//     private Vector2 currentPos;
//     // swipe direction
//     private Vector2 swipeDirection;
//     // touch controls
//     private TouchControls touchControls;

//     private PlayerController PC;
//     private MovementContorller MC;

//     public void Start(){
//         PC = player.GetComponent<PlayerController>();
//         MC = player.GetComponent<MovementContorller>();
//     }

//     private void Awake()
//     {
//         touchControls = new TouchControls();
//         touchControls.Enable();
//     }

//     private void OnEnable()
//     {
//         touchControls.TouchStart.performed += ctx => startPos = ctx.ReadValue<Vector2>();
//         touchControls.TouchPerformed.performed += OnTouchPerformed;
//         touchControls.TouchCancelled.performed += OnTouchCancelled;
//     }

//     private void OnDisable()
//     {
//         touchControls.TouchStart.performed -= ctx => startPos = ctx.ReadValue<Vector2>();
//         touchControls.TouchPerformed.performed -= OnTouchPerformed;
//         touchControls.TouchCancelled.performed -= OnTouchCancelled;
//     }

//     private void OnTouchPerformed(InputAction.CallbackContext context)
//     {
//         print("a");
//         //currentPos = context.ReadValue<Vector2>();
//         swipeDirection = currentPos - startPos;

//         if (swipeDirection.magnitude > swipeDistance)
//         {
//             if (Mathf.Abs(swipeDirection.x) > Mathf.Abs(swipeDirection.y))
//             {
//                 if (swipeDirection.x > 0)
//                 {
//                     // Swipe right
//                 }
//                 else
//                 {
//                     // Swipe left
//                 }
//             }
//             else
//             {
//                 if (swipeDirection.y > 0)
//                 {
//                     // Swipe up
//                 }
//                 else
//                 {
//                     // Swipe down
//                 }
//             }
//         }
//         else{
//             PC.Shoot();
//         }
//     }

//     private void OnTouchCancelled(InputAction.CallbackContext context)
//     {
//         // reset start position and swipe direction
//         startPos = Vector2.zero;
//         swipeDirection = Vector2.zero;
//     }
// }
        
