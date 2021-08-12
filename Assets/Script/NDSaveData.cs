using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NDSaveData : MonoBehaviour
{
    public List<string> listCH = new List<string>();
    public List<string> listDA = new List<string>();
    public ND nd;
    public void Save()
    {
        if (nd == null)
        {
            nd = FindObjectOfType<ND>();
        }
        SaveSystem.SaveArr(nd);

    }
    public void LoadData()
    {
        DataArr data = SaveSystem.LoadArr();

        listCH.AddRange(data.listCH);
        listDA.AddRange(data.listDA);
        GameObject test = new GameObject("ND");
        nd = test.AddComponent<ND>();
        nd.listCH = new List<string>(data.listCH);
        nd.listDA = new List<string>(data.listDA);
        if (nd != null)
        {
            DontDestroyOnLoad(nd);
            SceneManager.LoadScene("Start");
        }
    }
    public void Back()
    {
        SceneManager.LoadScene("Scene Start");
    }
}
