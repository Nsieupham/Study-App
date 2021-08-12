using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class DataArr 
{
    public List<string> listCH = new List<string>();
    public List<string> listDA = new List<string>();

    public DataArr (ND nd)
    {
        listCH.AddRange(nd.listCH);

        listDA.AddRange(nd.listDA);

    }

}
