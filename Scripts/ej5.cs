using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej5 : MonoBehaviour
{
    public Transform trCubo;// = GetComponent<Transform>();
    public Transform trCilindro;// = GetComponent<Transform>();

    // Start is called before the first frame update
    void Start()
    {
        Transform miTr = GetComponent<Transform>();
        Debug.Log("Distancia entre esfera y cubo: " + Vector3.Distance(miTr.position, trCubo.position));
        Debug.Log("Distancia entre esfera y cilindro: " + Vector3.Distance(miTr.position, trCilindro.position));
    }
}
