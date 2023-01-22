using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HealthText : MonoBehaviour
{
    public float timeToLive = .5f;
    public TextMeshPro textMesh;
    public float timeElapsed = 0.0f;
    public float floatSpeed = 50f;
    RectTransform rTransform;
    public Vector3 floatDirection = new Vector3(0,1,0);

    void Start()
    {
        floatSpeed = 50f;
        textMesh = GetComponent<TextMeshPro>();
        rTransform = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        timeElapsed += Time.deltaTime;
        rTransform.position += floatDirection*floatSpeed*Time.deltaTime;
        if(timeElapsed > timeToLive){
            Destroy(gameObject);
        }
    }
}
