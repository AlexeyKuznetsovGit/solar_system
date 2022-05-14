using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sun_script : MonoBehaviour
{
    public GameObject Sun;
    public void Update()
    {
        Sun.transform.Rotate(0, 0.005f, 0);
    }
}
