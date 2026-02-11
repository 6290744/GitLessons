using UnityEngine;
using UnityEngine.UIElements;

public class CubeRotator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Update()
    {
        this.transform.Translate(Vector3.up * Time.deltaTime);
    }
}
