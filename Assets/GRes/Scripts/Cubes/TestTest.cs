using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class TestTest : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("TestTest::Awake");
    }

    private void OnEnable()
    {
        Debug.Log("TestTest::OnEnable");
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("TestTest::Start");

        List<int> list = new() { 1, 2, 3 };
        StringBuilder builder = new();
        for (int i = 0; i < list.Count; i++)
        {
            if (i == 2)
            {
                list.Add(1000);
            }

            builder.Append(list[i] + " ");
        }
        
        Debug.Log("builder:" + builder);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("TestTest::Update");
    }
}

public class Entity
{
    
}

public class Blackboard
{
    
}

public struct jsonData
{
    
}

public delegate bool nodeTask(Entity entity, jsonData data, Blackboard blackboard);

public class Node
{
    public nodeTask[] tasks;

    public bool Evaluate(Entity entity, jsonData data, Blackboard blackboard)
    {
        return onEvaluate(entity, data, blackboard);
    }

    protected bool onEvaluate(Entity entity, jsonData data, Blackboard blackboard)
    {
        for (int i = 0; i < tasks.Length; i++)
        {
            bool ret = tasks[i](entity, data, blackboard);
            if (ret == false)
            {
                return false;
            }
        }

        return true;
    }
}
