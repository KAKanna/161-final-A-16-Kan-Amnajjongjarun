using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : Shape
{
    private float radius;
    float circlecal {  get; set; }

    private void Start()
    {
        shapeName = "Circle";
        radius = 2;
        Draw();
        Resize();
        Debug.Log($"{this.shapeName} have radius: {radius}");
        Debug.Log($"{this.shapeName} have area:{circlecal}");
    }
    public override float CalculateArea()
    {
        float Pi = 3.14f;
        circlecal = Pi * radius * radius;
        return circlecal;
    }
}
