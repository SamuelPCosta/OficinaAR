using UnityEngine;

public class SkyboxRotator : MonoBehaviour
{
    //Esse script apenas dah uma rodadinha no ceu pra deixar a cena mais dinamica
    public float rotationSpeed = 1f;

    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * rotationSpeed);
    }
}