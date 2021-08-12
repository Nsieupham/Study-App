using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    public void LoadSene1()
    {
        SceneManager.LoadScene("1");
    }
    public void LoadSene4()
    {
        SceneManager.LoadScene("4");
    }
    public void LoadSeneSaved()
    {
        SceneManager.LoadScene("Load");
    }
    public void SceneStart()
    { 
        GameObject nd = GameObject.Find("ND");

        if (nd != null)
        {
            DontDestroyOnLoad(nd);
            SceneManager.LoadScene("Start");
        }
    }  
}
