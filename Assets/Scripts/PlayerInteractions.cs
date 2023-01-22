using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractions : MonoBehaviour
{
    // private void OnCollisionEnter(Collision collision)
    // {
    // GetComponent<Renderer>().material.color = Color.red;
    // }

    private MaterialPropertyBlock _propBlock;
    private void Start()
    {
        _propBlock = new MaterialPropertyBlock();
    }

    private void OnCollisionEnter(Collision collision)
    {
        _propBlock.SetColor("_BaseColor", Color.red);
        GetComponent<Renderer>().SetPropertyBlock(_propBlock);
        Invoke(nameof(ResetColor),0.5f);
    }

    private void ResetColor()
    {
        _propBlock.SetColor("_BaseColor", Color.white);
        GetComponent<Renderer>().SetPropertyBlock(_propBlock);
    }
}
