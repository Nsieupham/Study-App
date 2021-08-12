using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class txtC : MonoBehaviour
{
    [SerializeField] Text tc;
    private GameObject Truy;
    private void Awake()
    {
        Truy = GameObject.Find("Excercide");
    }

    public void clickDA()
    {
        
        string click = GetComponent<txtC>().tc.text;
        string test = Truy.GetComponent<Excercide>().text1;
        if (click == test)
        {
            Truy.GetComponent<Excercide>().ar ++;
            if (Truy.GetComponent<Excercide>().ar == Truy.GetComponent<Excercide>().u)
            {
                SceneManager.LoadScene("Load");
            }
            else
            {
                Truy.GetComponent<Excercide>().Hien();
                Truy.GetComponent<Excercide>().Gan();
            }
        }
    }
}
