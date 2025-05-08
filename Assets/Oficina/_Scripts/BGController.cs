using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BGController : MonoBehaviour
{
    private float originalOpacity = 0;
    private bool isOpaque = false;

    void Start()
    {
        originalOpacity = transform.GetComponent<RawImage>().color.a;
    }

    // Alterna o BG do video entre translucido e opaco
    void Update()
    {
        if (Input.GetButtonDown("Submit"))
        {
            RawImage img = transform.GetComponent<RawImage>();
            Color newColor = img.color;
            newColor.a = isOpaque ? originalOpacity : 100;
            img.color = newColor;
            isOpaque = !isOpaque;
        }
    }
}
