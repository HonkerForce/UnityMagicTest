using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MonsterControl : MonoBehaviour
{
	private NavMeshAgent monsterAgent;
	public Transform targetTrans;
	public static readonly float TargetRadius = 0.5f;

	private RaycastHit mouseClickHit;

	// Start is called before the first frame update
	void Start()
    {
        monsterAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
	    if (Input.GetMouseButtonDown(0) && Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out mouseClickHit))
	    {
		    Vector3 pos = mouseClickHit.point;
		    float x = Math.Min(Math.Abs(pos.x - TargetRadius - transform.position.x),
			    Math.Abs(pos.x + TargetRadius - transform.position.x));
		    float y = transform.position.y;
		    float z = Math.Min(Math.Abs(pos.z - TargetRadius - transform.position.z),
			    Math.Abs(pos.z + TargetRadius - transform.position.z));
			// monsterAgent?.SetDestination(new Vector3(x, y, z));
			monsterAgent?.SetDestination(pos);

		}
	}
}
