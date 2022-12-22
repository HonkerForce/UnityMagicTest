using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
	public Animator playerAnimator;

    // Start is called before the first frame update
    void Start()
    {
		playerAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
	    if (Input.GetMouseButtonDown(0))
	    {
            playerAnimator?.SetBool("Go", true);
	    }
	    else if (Input.GetMouseButtonDown(1))
	    {
		    playerAnimator?.SetTrigger("Jump");
	    }

	    if (Input.GetMouseButtonUp(0))
	    {
		    playerAnimator?.SetBool("Go", false);
	    }
    }
}
