using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlerpRetate : MonoBehaviour
{
    public Transform[] objs;
    public int startIndex = 0;
    public int endIndex = 0;
    private int size = 0;
    private float timeLen = 0f;
    private float curTime = 0f;

    void Start()
    {
        if (objs != null)
        {
            size = objs.Length;
        }
    }

    void Update()
    {
        curTime += Time.deltaTime;
        startIndex %= size;
        endIndex = (startIndex + 1) % size;
        
        if (EquipF(timeLen, 0f))
        {
            timeLen = Random.Range(Mathf.Max(0.5f, Time.deltaTime), 2f);
        }

        var rot = Quaternion.Slerp(objs[startIndex].rotation, objs[endIndex].rotation, Mathf.Min(curTime / timeLen, 1f));
        transform.rotation = rot;
        var pos = Vector3.Lerp(objs[startIndex].position, objs[endIndex].position, Mathf.Min(curTime / timeLen, 1f));
        transform.position = pos;

        if (curTime >= timeLen)
        {
            curTime = 0f;
            timeLen = 0f;
            startIndex++;
        }
    }

    private bool EquipF(float a, float b)
    {
        return Mathf.Abs(a - b) < 0.00000001f;
    }
}
