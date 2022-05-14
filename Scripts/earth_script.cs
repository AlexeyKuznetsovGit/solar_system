using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class earth_script : MonoBehaviour
{
    [SerializeField]
    Transform center;

    [SerializeField]
    float radius = 5f, angularSpeed = 1.0f;

    float positionX, positionZ, angle = 0f;

    public GameObject Earth;
    public void Update()
    {
        Earth.transform.Rotate(0, 0.2f, 0);
        positionX = center.position.x + Mathf.Cos(angle) * radius;
        positionZ = center.position.z + Mathf.Sin(angle) * radius;
        transform.position = new Vector3(positionX, 0f ,positionZ);
        angle = angle + Time.deltaTime * angularSpeed;

        if (angle >= 360f)
        {
            angle = 0f;
        }
    }
}
