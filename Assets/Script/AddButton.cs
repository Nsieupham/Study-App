using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AddButton : MonoBehaviour
{
    [SerializeField] InputField inpQ;
    [SerializeField] InputField inpA;
    [SerializeField] Text outA;
    private GameObject NDLoader;


    //int a;

    public void Awake()
    {
        NDLoader = GameObject.Find("ND");
        //a = 0;
    }

    private void Start()
    {
       // a = -1;
    }

    public void ClickAdd()
    {
        // Nhập dữ liệu từ inpQ vào list
        //a++;
        NDLoader.GetComponent<ND>().listCH.Add(inpQ.text);
        NDLoader.GetComponent<ND>().listDA.Add(inpA.text);

        // Nhập list vào 1 biến tên text
        int n = NDLoader.GetComponent<ND>().listCH.Count;
        string text = String.Empty;
        for (int i = 0; i < n ; i++)
        {
            text += "\n" + "C" + ( i+1 ) + "." + NDLoader.GetComponent<ND>().listCH[i];
            text += "\n" + "     " + NDLoader.GetComponent<ND>().listDA[i];
        }
        outA.text = text;
    }
    public void ClickRe()
    {
        // Nhập dữ liệu từ inpQ vào list
        //a--;
        NDLoader.GetComponent<ND>().listCH.RemoveAt(NDLoader.GetComponent<ND>().listCH.Count - 1);
        NDLoader.GetComponent<ND>().listDA.RemoveAt(NDLoader.GetComponent<ND>().listDA.Count - 1);

        // Nhập list vào 1 biến tên text
        int n = NDLoader.GetComponent<ND>().listCH.Count;
        string text = String.Empty;
        for (int i = 0; i < n; i++)
        {
            text += "\n" + "C" + (i + 1) + "." + NDLoader.GetComponent<ND>().listCH[i];
            text += "\n" + "     " + NDLoader.GetComponent<ND>().listDA[i];
        }
        outA.text = text;
    }
}
