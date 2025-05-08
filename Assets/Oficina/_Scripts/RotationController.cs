using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationController : MonoBehaviour
{
    [SerializeField] private bool enableRotation = true;
    [SerializeField] private Transform ARCamera; //Componente q representa a camera do mundo real


    void Update()
    {
        //Quando ativada, habilita a rotacao da dupla banguela e soluco (no eixo Z) de acordo com a movimentacao da camera do mundo real
        if (enableRotation){
            float zRotation = ARCamera.eulerAngles.z;
            Vector3 currentEuler = transform.localEulerAngles;
            currentEuler.z = zRotation;
            transform.localEulerAngles = currentEuler;
        }
    }
}
