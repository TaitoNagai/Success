using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using UnityEngine.UI;

public class Save : MonoBehaviour
{
    public Text numInput;
    private string SaveFilePath;
    private void Awake()
    {
        SaveFilePath = Application.persistentDataPath + "/savedNum.save";
    }
    public void SaveManagement()
    {
        SaveData NowNumber = CreateSavePlayerData();
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(SaveFilePath);

        try
        {
            bf.Serialize(file, numInput);
        }
        finally
        {
            if(file != null)
            file.Close();
        }
    }
    private SaveData CreateSavePlayerData()
    {
        SaveData NowNumber = new SaveData();
        return NowNumber;
    }
}
