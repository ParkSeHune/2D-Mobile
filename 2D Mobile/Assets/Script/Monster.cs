using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    public int health;

    [SerializeField] SpriteRenderer sprite;

    public Monster()
    {
        Debug.Log("���Ͱ� �����Ǿ����ϴ�.");
    }

    //�����Լ�: virtual -> ���� Ŭ�������� �ٽ� ������ ��� �Լ�
    public virtual void Attack()
    {
        Debug.Log("������ ����Ǿ����ϴ�.");
    }
}