// using UnityEngine.InputSystem;
// using UnityEngine;

// public class TouchControls : MonoBehaviour
// {
//     public InputAction Touch;
//     public InputAction TouchStart;
//     public InputAction TouchPerformed;
//     public InputAction TouchCancelled;

//     private Vector2 startPos;
//     public float swipeDistance = 20f;

//     private void Awake()
//     {
//         // Touch = InputAction.Find("Touch");
//         // TouchStart = InputAction.Find("TouchStart");
//         // TouchPerformed = InputAction.GetActionMap("TouchPerformed");
//         // TouchCancelled = InputAction.Find("TouchCanceled");
//     }

//     public void Enable()
//     {
//         Touch.Enable();
//     }

//     public void Disable()
//     {
//         Touch.Disable();
//     }

//     public void OnTouchStarted(InputAction.CallbackContext context)
//     {
//         startPos = context.ReadValue<Vector2>();
//     }

//     public void OnTouchPerformed(InputAction.CallbackContext context)
//     {
//         Vector2 swipe = context.ReadValue<Vector2>() - startPos;

//         if (swipe.magnitude > swipeDistance)
//         {
//             if (Mathf.Abs(swipe.x) > Mathf.Abs(swipe.y))
//             {
//                 if (swipe.x > 0)
//                 {
//                     // Swipe right
//                 }
//                 else
//                 {
//                     // Swipe left
//                 }
//             }
//         }
//     }

//     public void OnTouchCancelled(InputAction.CallbackContext context)
//     {
//         // reset start position
//         startPos = Vector2.zero;
//     }
// }
