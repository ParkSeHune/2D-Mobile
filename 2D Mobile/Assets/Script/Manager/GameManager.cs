using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public enum state
    {
        Idle, //���� ���
        Progress, // ���� ������
        End //���� ����
    }

    private state currentState;

    private int score;

    private void Start()
    {
        State = state.Idle;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            State = state.Idle;
            StateMachine();
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            State = state.Progress;
            StateMachine();
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            State = state.End;
            StateMachine();
        }
    }

    public state State
    {
        get { return currentState; }
        
        set { currentState = value; }
    }

    public int Score
    {
        //�ش� ������ ����� �ִ� ���
        get { return score; }

        //�ش� ������ ���� ������ �ִ� ���
        set
        {
            score = value;

            if (score >= 100)
            {
                score = 0;
            }
        }
    }

    public void StateMachine()
    {
        switch (State)
        {
            case state.Idle:
                Time.timeScale = 0;
                break;
            case state.Progress:
                Time.timeScale = 1;
                break;
            case state.End:
                Time.timeScale = 0;
                break;
            default:
                break;
        }
    }
}