using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : Shape
{
    private int side;
    int sidecal {get;set;}

    private void Start()
    {
        shapeName = "Square";
        side = 5;
        Draw();
        Resize();
        Debug.Log($"{this.shapeName} have radius: {side}");
        Debug.Log($"{this.shapeName} have area:{sidecal}");
    }
    public override float CalculateArea()
    {
        sidecal = side * side;
        return sidecal;
    }
}
