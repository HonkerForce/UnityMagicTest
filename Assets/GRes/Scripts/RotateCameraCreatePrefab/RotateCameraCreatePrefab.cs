using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RotateCameraCreatePrefab : MonoBehaviour
{
    [SerializeField] private float rotateSpeed;
    public GameObject cubePref;

    public GameObject cubeRoot;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var dict = Input.GetAxis("Mouse X");
        if (rotateSpeed > 0)
        {
            var rotate = dict * rotateSpeed * Time.deltaTime;
            transform.Rotate(new Vector3(0f, rotate, 0f));
        }

        if (Input.GetMouseButtonDown(0))
        {
            var clickPoint =
                Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 4f));
        
            if (cubePref == null)
            {
                return;
            }
            
            var cube = Instantiate(cubePref, clickPoint, Quaternion.identity);
            cube?.transform.SetParent(cubeRoot?.transform);
        }
    }
}
