using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime : Monster
{
    public Slime()
    {
        health = 90;
        Debug.Log("�������� ü��: " + health);
        Debug.Log("�������� �����Ǿ����ϴ�.");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            Attack();
        }
    }

    public override void Attack()
    {
        Debug.Log("�������� ������ ����Ǿ����ϴ�.");
    }
}
