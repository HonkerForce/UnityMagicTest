using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public interface ITest
{
    
}

[System.Serializable]
public class TestBase : ITest
{
    [SerializeField] protected float ff;
}

[System.Serializable]
public class TestClass1 : TestBase
{
    [SerializeField] protected string str;
}

[System.Serializable]
public class TestClass2 : TestBase
{
    [SerializeField] protected int num;
}

[System.Serializable]
public class TestClass3 : TestBase
{
    [SerializeField] protected bool success;
}

public class TestMain : MonoBehaviour
{
    [SerializeReference] private ITest test1 = new TestClass1();
    [SerializeReference] private ITest test2 = new TestClass2();
    [SerializeField] private TestClass3 test3 = new TestClass3();

    [SerializeReference] private List<ITest> tests = new List<ITest>()
    {
        new TestClass1(),
        new TestClass2(),
        new TestClass3(),
    };


    [SerializeField] private Transform cube;
    void Start()
    {
        StringBuilder builder = new();
        builder.Append("asdjflasd");
        builder.Append(12);
        builder.AppendLine("aaaaaaaaaa");
        builder.AppendJoin("%d %d %d", 12, 11, 13);
        builder.AppendJoin(',', 1, 2, 3);
        builder.AppendLine("ddy");
        builder.AppendLine("fyy");
        Debug.Log(builder.ToString());
        
        builder[3] = '4';
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTestButtonClick(int index)
    {
        if (cube == null)
        {
            return;
        }
        
        Vector3 move = new(2, 4);

        switch (index)
        {
            case 1:
            {
                cube.Translate(move);
                break;
            }
            case 2:
            {
                var rigid = cube.GetComponent<Rigidbody>();
                if (rigid != null)
                {
                    rigid?.MovePosition(move);
                    
                    // Destroy(rigid);
                }
                break;
            }
            case 3:
            {
                var rigid = cube.GetComponent<Rigidbody>();
                if (rigid != null)
                {
                    rigid?.AddForce(move);
                }
                break;
            }
        }
    }
}
