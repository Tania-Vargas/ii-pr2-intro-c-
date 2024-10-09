using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej6 : MonoBehaviour
{
    public Vector3 desplazar_cubo, desplazar_cilindro, desplazar_esfera;
    private GameObject cubo, cilindro, esfera;

    // Start is called before the first frame update
    void Start()
    {
        desplazar_cubo = new Vector3(-1.29f, 0.0f, 1.0f);
        desplazar_cilindro = new Vector3(5.0f, 0.0f, 4.0f);
        desplazar_esfera = new Vector3(1.83f, 0.0f, -2.96f);

        cubo = GameObject.FindWithTag("cubo_azul");
        cilindro = GameObject.FindWithTag("cilindro_rosa");
        esfera = GameObject.FindWithTag("esfera_morada");
    }  

    void Update() {
        if (Input.GetKeyDown("space")) {
            cubo.transform.position = cubo.transform.position + desplazar_cubo;
            cilindro.transform.position = cilindro.transform.position + desplazar_cilindro;
            esfera.transform.position = esfera.transform.position + desplazar_esfera;
        }
    }  
}
