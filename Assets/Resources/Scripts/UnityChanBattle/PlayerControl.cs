using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerControl : MonoBehaviour
{
	private Animator playerAnimator;

	private RaycastHit hit;

	private NavMeshAgent playerAgent;

	// Start is called before the first frame update
    void Start()
    {
		playerAnimator = GetComponent<Animator>();
		playerAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
	    if (playerAgent != null && !playerAgent.hasPath)
	    {
		    playerAnimator?.SetBool("Go", false);
	    }

		if (Input.GetMouseButtonDown(0))
	    {
            playerAnimator?.SetBool("Go", true);
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit))
            {
				Vector3 pos = hit.point;
				playerAgent?.SetDestination(pos);
            }
            else
            {
	            Debug.LogError("无法获取鼠标点击的点位置");
				return;
            }
	    }
	    else if (Input.GetMouseButtonDown(1))
	    {
		    playerAnimator?.SetTrigger("Jump");
	    }
    }
}
