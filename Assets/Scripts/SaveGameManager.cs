using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public static class SaveGameManager
{
    public static void SaveGame(SaveData saveData) 
    {
        BinaryFormatter binaryFormatter = new BinaryFormatter();
        FileStream file;
        file = File.Create(Application.persistentDataPath + "/SaveData.kys");
        binaryFormatter.Serialize(file, saveData);
        file.Close();
    }

    public static SaveData LoadGame() 
    {
        if (File.Exists(Application.persistentDataPath + "/SaveData.kys")) 
        {
            try
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                FileStream file = File.Open(Application.persistentDataPath + "/SaveData.kys", FileMode.Open);
                SaveData saveData = (SaveData)binaryFormatter.Deserialize(file);
                file.Close();
                return saveData;
            }
            catch 
            {
                
            }
        }
        return null;
    }
}
