using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraScale : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var scrollWheel = Input.GetAxis("Mouse ScrollWheel");
        if (scrollWheel > 0)
        {
            if (Camera.main.fieldOfView < 50f)
            {
                Camera.main.fieldOfView += 5f;
            }

            if (Camera.main.orthographicSize < 10f)
            {
                Camera.main.orthographicSize += 0.5f;
            }
        }
        else if (scrollWheel < 0)
        {
            if (Camera.main.fieldOfView > 10f)
            {
                Camera.main.fieldOfView -= 5f;
            }

            if (Camera.main.orthographicSize > 1f)
            {
                Camera.main.orthographicSize -= 0.5f;
            }
        }
    }
}
