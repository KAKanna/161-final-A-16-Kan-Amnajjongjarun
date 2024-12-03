using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell : MonoBehaviour
{
    public virtual void Cast()
    {

    }
    public void Cast(string Name)
    {
        Name = "";
    }

    public void Cast(string Name, int Power)
    {
        Name = "";
        Power = 0;
    }
}
