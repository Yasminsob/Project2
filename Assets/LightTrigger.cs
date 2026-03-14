using UnityEngine;

public class LightTrigger : MonoBehaviour
{
    public Light sceneLight;
    public Color newColor = Color.red;
    public float newIntensity = 5f;

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            sceneLight.color = newColor;
            sceneLight.intensity = newIntensity;
        }
    }
}