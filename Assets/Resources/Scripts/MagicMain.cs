using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;
using UnityEngine.Events;

public class MagicMain : MonoBehaviour
{
	// public Transform parentObjTran = null;
	// [SerializeField] private bool mCanRotated = false;
	[SerializeField] private float mMoveSpeed = 0f;
	[SerializeField] private float mRotateSpeed = 0f;
	[SerializeField] private float mJumpHeight = 0f;

	new public Rigidbody rigidbody;

	public ObjectPool<GameObject> objPool;

	public UnityEvent<int, int> triggerEvent;

	public float MoveSpeed
	{
		get => mMoveSpeed;
	}

	public float RotationSpeed
	{
		get => mRotateSpeed;
	}

	public void PlayerRotate(Vector3 vecDict, float fAngle)
	{
		transform?.Rotate(vecDict, fAngle);
	}

	public void PlayerMove(Vector3 vecDict, float fMove)
	{
		transform?.Translate(vecDict * fMove);
	}

	public void SetPlayerEulerRotation(Vector3 vecRotation)
	{
		Debug.Log(vecRotation);
		transform.rotation = Quaternion.Euler(vecRotation);
	}

    void Start()
    {
	    objPool = new ObjectPool<GameObject>(() => new GameObject(), go => Debug.Log(go.name),
		    go => Debug.Log(go.name));

	    for (int i = 0; i < 9; i++)
	    {
		    var go = objPool.Get();
		    go.name = "DDY" + i;
	    }

		triggerEvent?.AddListener((a, b) => {Debug.Log(a + b);});
		triggerEvent?.Invoke(1, 2);
    }

    void Update()
    {
		if(Input.GetKey(KeyCode.Escape))
		{
			Cursor.visible = true;
			Cursor.lockState = CursorLockMode.None;
		}
		else if(Input.GetMouseButtonDown(0))
		{
			Cursor.visible = false;
			Cursor.lockState = CursorLockMode.Locked;
		}

		float horizontalMove = Input.GetAxis("Horizontal");
		float verticalMove = Input.GetAxis("Vertical");
		transform.Translate(new Vector3(horizontalMove, 0, verticalMove) * MoveSpeed * Time.deltaTime);

		float horizontalRotate = Input.GetAxis("Mouse X");
		transform.Rotate(new Vector3(0, horizontalRotate, 0) * RotationSpeed * Time.deltaTime);

		float jumpMove = Input.GetAxis("Jump");
		rigidbody?.AddForce(new Vector3(0, jumpMove, 0) * mJumpHeight * Time.deltaTime, ForceMode.Impulse);
    }
}
