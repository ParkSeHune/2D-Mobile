using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Data
{
    public int money;
    public int maxScore;
}


public class DataManager : MonoBehaviour
{
    public int currentScore = 0;

    public static DataManager instance;
    public Data data = new Data();

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        Load();

        Debug.Log("현제 소지하고 있는 돈: " + data.money);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            data.money++;
            currentScore++;

            if (data.maxScore <= currentScore)
            {
                data.maxScore = currentScore;
            }

            Save();

            Debug.Log("1. 현제 돈은: " + data.money);
            Debug.Log("2. 현제 점수는: " + currentScore);
            Debug.Log("3. 최고 점수는: " + data.maxScore);
        }
    }

    public void Save()
    {
        //데이터 클래스
        string json = JsonUtility.ToJson(data);

        byte[] bytes = System.Text.Encoding.UTF8.GetBytes(json);
        string code = System.Convert.ToBase64String(bytes);

        File.WriteAllText(Application.persistentDataPath + "/GameData.json", code);
    }

    public void Load()
    {
        string jsonData = File.ReadAllText(Application.persistentDataPath + "/GameData.json");

        byte[] bytes = System.Convert.FromBase64String(jsonData);
        string code = System.Text.Encoding.UTF8.GetString(bytes);

        data = JsonUtility.FromJson<Data>(code);
    }
}