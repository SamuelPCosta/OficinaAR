using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoCam : MonoBehaviour
{
    private bool isAutoCamera = false;
    [SerializeField] Transform shoulderCamPoint;

    private Vector3 startLocalPos;
    private Quaternion startLocalRot;
    private GameObject startPoint;

    void Start()
    {
        startLocalPos = transform.localPosition;
        startLocalRot = transform.localRotation;

        startPoint = new GameObject("StartPoint");
        startPoint.transform.SetParent(transform.parent);
        startPoint.transform.localPosition = startLocalPos;
        startPoint.transform.localRotation = startLocalRot;
    }

    public void enableAutoCam()
    {
        StartCoroutine(MoveTo(transform, shoulderCamPoint));
        isAutoCamera = true;
    }

    public void disableAutoCam()
    {
        if (true)
        {
            StartCoroutine(MoveTo(transform, startPoint.transform));
            isAutoCamera = false;
        }
    }

    IEnumerator MoveTo(Transform target, Transform destiny)
    {
        Vector3 startPos = target.localPosition;
        Quaternion startRot = target.localRotation;
        float elapsed = 0f;

        while (elapsed < 1f)
        {
            float t = elapsed / 1f;
            target.localPosition = Vector3.Lerp(startPos, destiny.localPosition, t);
            target.localRotation = Quaternion.Slerp(startRot, destiny.localRotation, t);
            elapsed += Time.deltaTime;
            yield return null;
        }

        target.localPosition = destiny.localPosition;
        target.localRotation = destiny.localRotation;
    }
}
