using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public enum state
    {
        Idle, //게임 대기
        Progress, // 게임 진행중
        End //게임 종료
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
        //해당 변수를 출력해 주는 기능
        get { return score; }

        //해당 변수에 값을 대입해 주는 기능
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