using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class SaveData : MonoBehaviour {
    public  void SaveRecord(string RecordBall)
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream stream = new FileStream(Application.persistentDataPath+ "/ballSav.dat", FileMode.Create);
        string record = RecordBall;
        bf.Serialize(stream,record);
        stream.Close();
    }
    public  string LoadRecord()
    {
        string record = "0";
        if (File.Exists(Application.persistentDataPath + "/ballSav.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream stream = new FileStream(Application.persistentDataPath + "/ballSav.dat", FileMode.Open);
             record = bf.Deserialize(stream) as string;
            stream.Close();
        }
       
        return record;
    }
    public void SaveGems(string GemsBall)
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream stream = new FileStream(Application.persistentDataPath + "/GemsSav.dat", FileMode.Create);
        string record = GemsBall;
        bf.Serialize(stream, record);
        stream.Close();
    }
    public string LoadGems()
    {
        string gems = "0";
        if (File.Exists(Application.persistentDataPath + "/GemsSav.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream stream = new FileStream(Application.persistentDataPath + "/GemsSav.dat", FileMode.Open);
            gems = bf.Deserialize(stream) as string;
            stream.Close();
        }

        return gems;
    }




    //------------------------------------------------------------------------------------------------------------//
    public void SaveColor(string Color) {

        BinaryFormatter bf = new BinaryFormatter();
        FileStream stream = new FileStream(Application.persistentDataPath + "/ballCol.dat", FileMode.Create);
        string color = Color;
        bf.Serialize(stream, color);
        stream.Close();


    }
    public string LoadColor()
    {

        string record = "red";
        if (File.Exists(Application.persistentDataPath + "/ballCol.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream stream = new FileStream(Application.persistentDataPath + "/ballCol.dat", FileMode.Open);
            record = bf.Deserialize(stream) as string;
            stream.Close();
        }

        return record;
    }
}
