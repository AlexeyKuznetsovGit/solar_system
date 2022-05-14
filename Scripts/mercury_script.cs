using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mercury_script : MonoBehaviour
{
    [SerializeField]
    Transform center;

    [SerializeField]
    float radius = 1.5f, angularSpeed = 2f;

    float positionX, positionZ, angle = 0f;

    public GameObject Mercury;
    public void Update()
    {
        Mercury.transform.Rotate(0, 0.05f, 0);
        positionX = center.position.x + Mathf.Cos(angle) * radius;
        positionZ = center.position.z + Mathf.Sin(angle) * radius;
        transform.position = new Vector3(positionX, 0f, positionZ);
        angle = angle + Time.deltaTime * angularSpeed;

        if (angle >= 360f)
        {
            angle = 0f;
        }
    }
}
