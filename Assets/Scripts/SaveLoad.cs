using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class SaveLoad : MonoBehaviour
{
    public string name = "null";
    public int score = 0;
    void Start()
    {
        Load();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)) score++;
    }

    void Save()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/NameAndScore.gd");
        bf.Serialize(file, name);
        bf.Serialize(file, score);
        file.Close();
    }

    void Load()
    {
        if (File.Exists(Application.persistentDataPath + "/NameAndScore.gd"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/NameAndScore.gd", FileMode.Open);
            name = bf.Deserialize(file).ToString();
            score = int.Parse(bf.Deserialize(file).ToString());
            file.Close();
        }
    }

    void OnGUI()
    {
        name = GUI.TextField(new Rect(10,10,200,20), name, 25);
        GUI.Label(new Rect(0,30,120,20),("score : " + score.ToString()));
        if (GUI.Button(new Rect(250, 5, 50, 30), "save"))
        {
            Save();
        }
    }
}
