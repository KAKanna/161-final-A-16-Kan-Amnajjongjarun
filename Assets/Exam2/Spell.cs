using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell : MonoBehaviour
{
    public virtual void Cast()
    {

    }
    public void Cast(string spellName)
    {
        spellName = "";
    }

    public void Cast(string spellName, int spellPower)
    {
        spellName = "";
        spellPower = 0;
    }
}
