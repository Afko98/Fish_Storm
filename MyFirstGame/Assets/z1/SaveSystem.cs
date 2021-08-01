using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{
   
    public static void SavePlayer()
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/data.thesenuts";
        FileStream stream = new FileStream(path, FileMode.Create);

        Data data = new Data();

        formatter.Serialize(stream, data);
        stream.Close();
    }
    public static Data LoadPlayer()
    {
        string path = Application.persistentDataPath + "/data.thesenuts";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            Data data = formatter.Deserialize(stream) as Data;
            stream.Close();
            return data;

        }
        else
        {
            Debug.Log("Save file not found!" + path);
            return null;
        }
    }
}
