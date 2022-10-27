using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boom : Weapon
{
    private void Start()
    {
        Effect();
    }

    public override void Effect()
    {
        //throw new System.NotImplementedException();
        Debug.Log("Æã");
    }
}
