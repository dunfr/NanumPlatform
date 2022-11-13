using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class NoteData
{
    public int a;
}
public class DataManager : MonoBehaviour
{
    private static DataManager instance;
    NoteData noteData = new NoteData();
    string path;
    public string filename = "firstData";
    void Awake()
    {
        if (null == instance)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
        path = Application.persistentDataPath+"/";
    }
    public static DataManager Instance
    {
        get
        {
            if (null == instance)
            {
                return null;
            }
            return instance;
        }
    }
    void Start()
    {
        saveData();
        Debug.Log(path);
    }
    public void saveData()
    {
        string data = JsonUtility.ToJson(noteData,true);
        noteData.a += 1;
        File.WriteAllText(path + filename, data);
    }
    public void LoadData()
    {
        string data = File.ReadAllText(path + filename);
        noteData = JsonUtility.FromJson<NoteData>(data);
    }
}
