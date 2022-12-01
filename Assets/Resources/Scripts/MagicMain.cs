using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class MagicMain : MonoBehaviour
{
	// public Transform parentObjTran = null;
	// [SerializeField] private bool mCanRotated = false;
	[SerializeField] private float mMoveSpeed = 0f;
	[SerializeField] private float mRotateSpeed = 0f;

	public ObjectPool<GameObject> objPool;

	// public bool IsRotated
	// {
	// 	get { return mCanRotated; }
    //     set { mCanRotated = value; }
	// }

	public float MoveSpeed
	{
		get { return mMoveSpeed; }
		set { mMoveSpeed = value; }
	}

	public float RotationSpeed
	{
		get { return mRotateSpeed; }
		set { mRotateSpeed = value; }
	}

	public void PlayerRotate(Vector3 vecDict, float fAngle)
	{
		transform.Rotate(vecDict, fAngle);
	}

	public void PlayerMove(Vector3 vecDict, float fMove)
	{
		transform.Translate(vecDict * fMove);
	}

	public void SetPlayerEulerRotation(Vector3 vecRotation)
	{
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
    }

    void Update()
    {
		if (Input.GetKey(KeyCode.W))
		{
			// SetPlayerEulerRotation(new Vector3(RotationSpeed, 0, 0));
			PlayerMove(Vector3.forward, MoveSpeed * Time.deltaTime);
		}
		else if(Input.GetKeyUp(KeyCode.W))
		{
			SetPlayerEulerRotation(Vector3.zero);
		}
		else if(Input.GetKey(KeyCode.S))
		{
			// SetPlayerEulerRotation(new Vector3(RotationSpeed, 180, 0));
			PlayerMove(Vector3.back, MoveSpeed * Time.deltaTime);
		}
		else if(Input.GetKeyUp(KeyCode.S))
		{
			SetPlayerEulerRotation(Vector3.zero);
		}
		else if(Input.GetKey(KeyCode.A))
		{
			// SetPlayerEulerRotation(new Vector3(RotationSpeed, -90, 0));
			PlayerMove(Vector3.left, MoveSpeed * Time.deltaTime);
		}
		else if(Input.GetKeyUp(KeyCode.A))
		{
			SetPlayerEulerRotation(Vector3.zero);
		}
		else if(Input.GetKey(KeyCode.D))
		{
			// SetPlayerEulerRotation(new Vector3(RotationSpeed, 90, 0));
			PlayerMove(Vector3.right, MoveSpeed * Time.deltaTime);
		}
		else if(Input.GetKeyUp(KeyCode.D))
		{
			SetPlayerEulerRotation(Vector3.zero);
		}
    }
}
