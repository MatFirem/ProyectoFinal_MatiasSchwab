using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionEscenario : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(new Vector3(0, 0.10f, 0));
    }
}
