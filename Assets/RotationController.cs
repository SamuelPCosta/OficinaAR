using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationController : MonoBehaviour
{
    [SerializeField] private bool invertRotation = true;
    [SerializeField] private Transform ARCamera;

    void Update()
    {
        if (invertRotation){
            float zRotation = ARCamera.eulerAngles.z;
            Vector3 currentEuler = transform.localEulerAngles;
            currentEuler.z = zRotation;
            transform.localEulerAngles = currentEuler;
        }
    }
}
