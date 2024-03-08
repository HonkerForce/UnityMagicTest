using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempleState : MonoBehaviour
{
	static bool[] states = new bool[2];

	public static void SetMachineState(int nIndex)
	{
		if (nIndex < 0 || nIndex > states.Length)
		{
			return;
		}

		states[nIndex] = true;

		foreach (var figure in states)
		{
			if (!figure)
			{
				return;
			}
		}

		TempleEvent.passEvent?.Invoke();
	}

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
