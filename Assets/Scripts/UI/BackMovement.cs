using UnityEngine;

public class BackMovement : MonoBehaviour
{
    [Range(-1f,1f)]
    public float speed = 0.1f;
    private Material mat;

    void Start(){
        mat = GetComponent<Renderer>().material;
    }

    void FixedUpdate()
    {
        float offset = Time.time* speed;
        mat.SetTextureOffset("_MainTex", new Vector2(offset/10,0));
    }
}
