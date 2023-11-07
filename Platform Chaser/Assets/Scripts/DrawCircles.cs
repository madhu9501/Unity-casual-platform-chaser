using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawCircles : MonoBehaviour
{
    public float radius;
    public float width;
    // Start is called before the first frame update
    void Awake()
    {
        radius =2f;
        width =0.1f;
        GameObject go = new GameObject {
            name = "Circle"
        };
        go.transform.parent = transform;
        go.transform.localPosition = Vector3.zero;
        go.DrawCircle(width, radius);

    }
}
