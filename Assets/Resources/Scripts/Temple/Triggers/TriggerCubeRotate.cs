using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCubeRotate : MonoBehaviour
{
	bool bEnter = false;

    void Start()
    {
        
    }

    void Update()
    {
		if(bEnter && Input.GetKeyDown(KeyCode.J))
		{
			TempleEvent.rotateEvent();
		}
    }

	private void OnTriggerEnter(Collider other) 
	{
		if(other.gameObject.tag == "Player")
		{
			bEnter = true;
		}
	}

	private void OnTriggerExit(Collider other) 
	{
		if(other.gameObject.tag == "Player")
		{
			bEnter = false;
		}
	}
}
