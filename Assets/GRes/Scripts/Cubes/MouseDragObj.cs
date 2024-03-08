using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDragObj : MonoBehaviour
{
	private void Awake()
	{
		Debug.Log("MouseDragObj::Awake");
	}

	private void OnEnable()
	{
		Debug.Log("MouseDragObj::OnEnable");
	}

	void Start()
    {
	    Debug.Log("MouseDragObj::Start");
    }

    void Update()
    {
	    Debug.Log("MouseDragObj::Update");
    }

	private void OnMouseDrag() 
	{
		Vector3 objPosition = Camera.main.WorldToScreenPoint(transform.position);
		Vector3 mainCameraPosition = Input.mousePosition;
		mainCameraPosition.z = objPosition.z;
		transform.position = Camera.main.ScreenToWorldPoint(mainCameraPosition);
	}
}
