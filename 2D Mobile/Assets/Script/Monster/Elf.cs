using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elf : Monster
{
    public Elf()
    {
        health = 100;
        Debug.Log("Elf의 체력: " + health);
        Debug.Log("엘프가 생성되었습니다.");
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
        Debug.Log("Elf의 공격이 실행되었습니다.");
    }
}
