using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEnterRoom : MonoBehaviour
{
	// 传入游戏位置trans
	[SerializeField] Transform pos;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

	private void OnTriggerEnter(Collider player) 
	{
		if (player.tag == "Player")
		{
			TempleEvent.moveEvent?.Invoke(pos);
		}
	}
}
