using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Utility
{
    public static void DrawCircle(this GameObject container, float width, float radius){
        LineRenderer lineRenderer = container.AddComponent<LineRenderer>();
        
        lineRenderer.useWorldSpace = false;
        lineRenderer.startWidth = width;
        lineRenderer.endWidth = width;
        // 360 -> gives index out of range error
        lineRenderer.positionCount = 360 + 1;

        var points = new Vector3[lineRenderer.positionCount];
        for(int i=0; i<points.Length; i++){
            var rad = Mathf.Deg2Rad * i;
            points[i] = new Vector3(Mathf.Cos(rad) * radius, 0f, Mathf.Sin(rad) * radius);
        }
        lineRenderer.SetPositions(points);
    }
}
