using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class SaveSystem : MonoBehaviour
{
    public static void SaveArr(ND nd)
    {
        BinaryFormatter fomatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/nd.fun";
        FileStream stream = new FileStream(path, FileMode.Create);
        
        DataArr data = new DataArr(nd);

        fomatter.Serialize(stream, data);
        stream.Close();
    }

    public static DataArr LoadArr()
    {
        string path = Application.persistentDataPath + "/nd.fun";
        if(File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            DataArr data = formatter.Deserialize(stream) as DataArr;
            stream.Close();

            return data;

        }else
        {
            Debug.LogError("Save file not found in " + path);
            return null;
        }
    }
}
