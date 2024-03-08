using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MonsterControl : MonoBehaviour
{
	public Vector3 initPos;

	private NavMeshAgent monsterAgent;

	private Vector3 targetPos;

	// private RaycastHit mouseClickHit;

	void Awake()
	{
		if (GameControl.targetChange == null)
		{
			GameControl.targetChange = ChangeTargetPos;
		}

		if (GameControl.initMonster == null)
		{
			GameControl.initMonster = InitMonster;
		}
	}

	void Start()
    {
        monsterAgent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
	    if (GameControl.gameIsPause)
	    {
		    if (monsterAgent.hasPath)
		    {
			    monsterAgent.isStopped = true;
		    }
		    return;
	    }

	    if (monsterAgent != null && targetPos != monsterAgent.destination)
	    {
		    // Vector3 pos = mouseClickHit.point;
			monsterAgent?.SetDestination(targetPos);
	    }
	}

    void ChangeTargetPos(Vector3 pos)
    {
	    if (targetPos != pos)
	    {
		    targetPos = pos;
	    }
    }

    void InitMonster()
    {
	    transform.position = initPos;

	    if (monsterAgent != null)
	    {
		    monsterAgent.isStopped = false;
	    }
    }
}
