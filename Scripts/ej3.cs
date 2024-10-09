using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej3 : MonoBehaviour
{

    public Vector3 vector_1, vector_2;
    private Transform tr;

    void Start()
    {
        // La magnitud de cada uno de ellos 
        
        Debug.Log("1. Magnitudes: (vector 1)" + vector_1.magnitude + "; (vector 2)" + vector_2.magnitude);
        // El ángulo que forman
        Debug.Log("2. Ángulo que forman: " + Vector3.Angle(vector_1, vector_2));
        // La distancia entre ambos
        Debug.Log("3. Distancia: " + Vector3.Distance(vector_1, vector_2));
        // Un mensaje indicando qué vector está a una altura mayor
        string highest = "vector_1";
        if (vector_1.y < vector_2.y) { highest = "vector_2"; }
        Debug.Log("4. El vector a mayor altura es " + highest);
        
    }
}
