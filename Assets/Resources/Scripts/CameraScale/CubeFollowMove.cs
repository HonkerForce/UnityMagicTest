using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CubeFollowMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(UpdateCubePos());
        }
    }

    IEnumerator UpdateCubePos()
    {
        var curCubeScreenPos = Camera.main.WorldToScreenPoint(transform.position);
        var mouseWorldPos =
            Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y,
                curCubeScreenPos.z));
        var offset = transform.position - mouseWorldPos;

        while (Input.GetMouseButton(0))
        {
            var curMouseWorldPos =
                Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y,
                    curCubeScreenPos.z));
            transform.position = offset + curMouseWorldPos;

            yield return new WaitForFixedUpdate();
        }
    }
}
