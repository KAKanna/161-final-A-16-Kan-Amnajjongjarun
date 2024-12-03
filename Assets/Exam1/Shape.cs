using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    protected string shapeName { get;set;}

    public void Constructor(string Init)
    {}
    public abstract float CalculateArea();

    public virtual void Resize()
    {
        Debug.Log($"{this.shapeName} Resize...");
    }

    public void Draw()
    {
        Debug.Log($"{this.shapeName} is Drawing...");
    }
}
