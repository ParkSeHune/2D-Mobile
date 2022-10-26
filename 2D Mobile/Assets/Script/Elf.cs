using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elf : Monster
{
    public Elf()
    {
        health = 100;
        Debug.Log("Elf�� ü��: " + health);
        Debug.Log("������ �����Ǿ����ϴ�.");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            Attack();
        }
    }

    public override void Attack()
    {
        Debug.Log("Elf�� ������ ����Ǿ����ϴ�.");
    }
}
