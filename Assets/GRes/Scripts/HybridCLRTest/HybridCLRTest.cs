using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class Hello
{
    public static void Run()
    {
        Debug.Log("Hello, HybridCLR");
    }
}

public class HybridCLRTest : MonoBehaviour
{
    void Start()
    {
        HybridCLR.RuntimeApi.LoadMetadataForAOTAssembly(new byte[] { }, HybridCLR.HomologousImageMode.SuperSet);
        // Editor环境下，HotUpdate.dll.bytes已经被自动加载，不需要加载，重复加载反而会出问题。
#if !UNITY_EDITOR
        Assembly hotUpdateAss = Assembly.Load(File.ReadAllBytes($"{Application.streamingAssetsPath}/HotUpdate.dll.bytes"));
#else
        // Editor下无需加载，直接查找获得HotUpdate程序集
        Assembly hotUpdateAss = System.AppDomain.CurrentDomain.GetAssemblies().First(a => a.GetName().Name == "HotUpdate");
#endif
        
        Type type = hotUpdateAss.GetType("Hello");
        type.GetMethod("Run").Invoke(null, null);

        Addressables.InstantiateAsync("Assets/GRes/Prefabs/HybridCLRTest/PrintLog.prefab");
    }
}