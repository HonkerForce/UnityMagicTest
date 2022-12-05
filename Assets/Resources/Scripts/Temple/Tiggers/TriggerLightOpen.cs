using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerLightOpen : MonoBehaviour
{
	public int? nIndex;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

	private void OnTriggerEnter(Collider other) 
	{
		if(other.gameObject.tag == "Point")
		{
			TempleEvent.figureEvent?.Invoke(nIndex??-1);
		}
	}
}
