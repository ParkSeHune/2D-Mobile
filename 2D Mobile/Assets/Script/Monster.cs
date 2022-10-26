using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    public int health;

    [SerializeField] SpriteRenderer sprite;

    public Monster()
    {
        Debug.Log("몬스터가 생성되었습니다.");
    }

    //가상함수: virtual -> 하위 클래스에서 다시 정의할 멤버 함수
    public virtual void Attack()
    {
        Debug.Log("공격이 실행되었습니다.");
    }
}