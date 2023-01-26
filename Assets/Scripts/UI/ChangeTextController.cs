using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangeTextController : MonoBehaviour
{
    public TextMeshProUGUI mesh;
    public string init;
    public string next;


    public void ChangeText(){
        mesh.text = next;
        (init,next)=(next,init);
    }
}
