using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create : MonoBehaviour
{
    private void Awake()
    {
        GameObject dp = new GameObject("ND");
        dp.AddComponent<ND>();
    }
}
