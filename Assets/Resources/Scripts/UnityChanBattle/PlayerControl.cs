using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;

public class PlayerControl : MonoBehaviour
{
	public Vector3 initPos;

	private Animator playerAnimator;

	private RaycastHit hit;

	private NavMeshAgent playerAgent;

	private ParticleSystem[] particleSystems;

	public static bool isAttacking = false;

	void Awake()
	{
		if (GameControl.initPlayer == null)
		{
			GameControl.initPlayer = InitPlayer;
		}
	}

    void Start()
    {
		playerAnimator = GetComponent<Animator>();
		playerAgent = GetComponent<NavMeshAgent>();
		particleSystems = GetComponentsInChildren<ParticleSystem>();
    }

    void Update()
    {
	    if (GameControl.gameIsPause)
	    {
		    return;
	    }

	    if (playerAgent != null && !playerAgent.hasPath)
	    {
		    playerAnimator?.SetBool("Go", false);
	    }

	    GameControl.targetChange?.Invoke(transform.position);

		if (Input.GetMouseButtonUp(0))
	    {
            playerAnimator?.SetBool("Go", true);
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit) && !EventSystem.current.IsPointerOverGameObject())
            {
				Vector3 pos = hit.point;
				playerAgent?.SetDestination(pos);
            }
    //         else
    //         {
	   //          Debug.LogError("无法获取鼠标点击的点位置");
				// return;
    //         }
	    }
	    else if (Input.GetMouseButtonUp(1))
	    {
		    playerAnimator?.SetTrigger("Jump");
		    foreach (var particle in particleSystems)
		    {
			    if (!particle.isPlaying)
			    {
				    particle.Play();
			    }
		    }

		    isAttacking = true;
			Invoke("StopAttack", 1f);
	    }
    }

    void InitPlayer()
    {
	    transform.position = initPos;
    }

    void StopAttack()
    {
	    isAttacking = false;
    }
}
