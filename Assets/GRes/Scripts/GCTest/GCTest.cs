using System.Collections;
using System.Collections.Generic;
using UnityEngine;

struct MyStruct
{
    private int num;
}
public class GCTest : MonoBehaviour
{
    private List<MyStruct> objPool = new();
    private Dictionary<int, int> dic = new();
    void Start()
    {
        
    }

    void Update()
    {
        var objs = FindObjectsOfType<Transform>();
        if (objs != null)
        {
            var go = new GameObject("DDY");
        }

        // if (objPool.Count == 0)
        // {
        //     for (int i = 0; i < 1000000; i++)
        //     {
        //         objPool.Add(new MyStruct());
        //     }
        // }
    }
}
