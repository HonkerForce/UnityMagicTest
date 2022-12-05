using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempleEvent : MonoBehaviour
{
	// 机关移动委托事件
	public static Action<Transform> moveEvent;

	// 机关触发委托事件
	public static Action<int> figureEvent;

	// 机关旋转委托事件
	public static Action rotateEvent;

	// 通关委托事件
	public static Action passEvent;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
