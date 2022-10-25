using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Data
{
    public int money;
}


public class DataManager : MonoBehaviour
{
    public static DataManager instance;
    public Data data = new Data();

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        Load();

        Debug.Log(data.money);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            data.money++;
            Save();

            Debug.Log(data.money);
        }
    }

    public void Save()
    {
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