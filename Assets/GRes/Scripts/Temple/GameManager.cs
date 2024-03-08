using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	// 玩家trans
	[SerializeField] Transform playerTrans;

	// 方体trans
	[SerializeField] Transform cubeTrans;

	// 灯光游戏体组
	[SerializeField] GameObject[] lightObjs;

	// 围栏游戏体
	[SerializeField] GameObject fenceObj;

    void Start()
    {
        TempleEvent.moveEvent += pos =>
		{
			playerTrans.position = pos.position;
			playerTrans.rotation = pos.rotation;
		};

		TempleEvent.figureEvent += nIndex =>
		{
			if(nIndex < 0)
			{
				Debug.Log("非法关键节点被连通触发！" + nIndex);
				return;
			}
			TempleState.SetMachineState(nIndex);
			lightObjs[nIndex].SetActive(true);
		};

		TempleEvent.rotateEvent += () =>
		{
			cubeTrans.Rotate(Vector3.up * 90);
		};

		TempleEvent.passEvent += () =>
		{
			fenceObj.SetActive(false);
		};
    }

    void Update()
    {
        
    }
}
