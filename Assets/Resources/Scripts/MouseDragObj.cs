using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDragObj : MonoBehaviour
{
    void Start()
    {
    }

    void Update()
    {
    }

	private void OnMouseDrag() 
	{
		Vector3 objPosition = Camera.main.WorldToScreenPoint(transform.position);
		Vector3 mainCameraPosition = Input.mousePosition;
		mainCameraPosition.z = objPosition.z;
		transform.position = Camera.main.ScreenToWorldPoint(mainCameraPosition);
	}
}
