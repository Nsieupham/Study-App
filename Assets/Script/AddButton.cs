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


    int a;

    // Tuy cập list trong lớp ND. Cách thức đặc biệt
    ND nd;
    private void Awake()
    {
        GameObject dp = new GameObject("ND");
        nd = dp.AddComponent<ND>();
    }

    private void Start()
    {
        a = -1;
    }

    public void ClickAdd()
    {
        // Nhập dữ liệu từ inpQ vào list
        a++;
        nd.listCH.Add(inpQ.text);
        nd.listDA.Add(inpA.text);

        // Nhập list vào 1 biến tên text
        int n = nd.listCH.Count;
        string text = String.Empty;
        for (int i = 0; i < n ; i++)
        {
            text += "\n" + "C" + ( i+1 ) + "." + nd.listCH[i];
            text += "\n" + "     " + nd.listDA[i];
        }
        outA.text = text;
    }
}
