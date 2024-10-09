using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Transform tr = GetComponent<Transform>();
        Debug.Log("Posición de la esfera " + tr.position);
    }
}
