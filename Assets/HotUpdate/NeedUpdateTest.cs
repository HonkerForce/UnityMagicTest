using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.UI;

public class Hello
{
    public static void Run()
    {
        List<int> nums = new();
        Dictionary<int, int> hs = new();
        GameObject go = new("Test");
        go.AddComponent<Image>();
        // AsyncOperationHandle<Object> handle = new();
        // AsyncOperationHandle<List<int>> handle1 = new();
        // handle.Completed += operationHandle => handle1.Completed += asyncOperationHandle => Debug.Log("");

        Debug.Log("Hello, HybridCLR");
        Debug.Log("Hello, Offer!");
    }
}