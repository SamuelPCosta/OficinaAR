using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private float moveAmount = 0.002f;
    [SerializeField] private Transform islands;

    void Update()
    {
        float rotationY = transform.localEulerAngles.y;
        if (rotationY > 180f) rotationY -= 360f;

        float rotationX = transform.localEulerAngles.x;
        if (rotationX > 180f) rotationX -= 360f;

        float offsetY = Mathf.Min(0f, moveAmount * rotationX);

        Vector3 offset = new Vector3(
            -moveAmount * rotationY,
            offsetY,
            0f
        );

        islands.localPosition += offset;
    }
}
