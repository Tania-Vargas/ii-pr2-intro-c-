using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej7 : MonoBehaviour
{

    private Renderer render;
    private string tag;

    // Start is called before the first frame update
    void Start()
    { 
        render = GetComponent<Renderer>(); 
        tag = gameObject.tag;
    }

    // Update is called once per frame
    void Update()
    {
        if (tag == "cilindro_rosa" && Input.GetKeyDown("c")) {
            render.material.color = Random.ColorHSV();
        }
        if (tag == "cubo_azul" && Input.GetKeyDown("up")) {
            render.material.color = Random.ColorHSV();
        }
    }
}
