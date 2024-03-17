using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderRigibody : MonoBehaviour
{
    void OnCollisionEnter()
    {
        print(gameObject.name + "Collision Enter");
    }

    private void OnCollisionStay(Collision collisionInfo)
    {
        print(gameObject.name + "Collision Stay");
    }

    private void OnCollisionExit(Collision other)
    {
        print(gameObject.name + "Collision Exit");
    }

    private void OnTriggerEnter(Collider other)
    {
        print(gameObject.name + "Trigger Enter");
    }

    private void OnTriggerStay(Collider other)
    {
        print(gameObject.name + "Trigger Stay");
    }

    private void OnTriggerExit(Collider other)
    {
        print(gameObject.name + "Trigger Exit");
    }
}
