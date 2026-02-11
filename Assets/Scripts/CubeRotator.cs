using UnityEngine;
using UnityEngine.UIElements;

public class CubeRotator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Update()
    {
        this.transform.RotateAround(Vector3.zero, Vector3.up, Time.deltaTime * 10f);
    }
}
