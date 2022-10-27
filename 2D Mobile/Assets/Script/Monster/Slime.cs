using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime : Monster
{
    public Slime()
    {
        health = 90;
        Debug.Log("슬라임의 체력: " + health);
        Debug.Log("슬라임이 생성되었습니다.");
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
        Debug.Log("슬라임의 공격이 실행되었습니다.");
    }
}
