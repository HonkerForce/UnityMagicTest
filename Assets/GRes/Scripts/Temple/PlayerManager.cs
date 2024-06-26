using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
	public float moveSpeed = 0f;
	public float rotateSpeed = 0f;

    void Start()
    {
        
    }

    void Update()
    {
	    if (Input.GetKey(KeyCode.Escape))
	    {
		    Cursor.visible = true;
		    Cursor.lockState = CursorLockMode.None;
	    }
		else if (Input.GetMouseButtonDown(0))
	    {
		    Cursor.visible = false;
		    Cursor.lockState = CursorLockMode.Locked;
	    }
    }

	private void FixedUpdate() 
	{
		float horizontalMove = Input.GetAxis("Horizontal");
		float verticalMove = Input.GetAxis("Vertical");
		transform.Translate(new Vector3(horizontalMove, 0, verticalMove) * moveSpeed * Time.fixedDeltaTime);

		float mouseRotation_X = Input.GetAxis("Mouse X");
		transform.Rotate(new Vector3(0, mouseRotation_X, 0) * rotateSpeed * Time.fixedDeltaTime);
	}
}
