using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej1 : MonoBehaviour
{
        public int waitingFrames = 120;
        private int frameCounter = 0;
        private Renderer render;
        private Vector3 obColor;

    // Start is called before the first frame update
    void Start()
    {
        render = GetComponent<Renderer>();
        obColor = new Vector3(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
        render.material.color = new Color(obColor[0], obColor[1], obColor[2]);
    }

    // Update is called once per frame
    void Update()
    {
        if (frameCounter == waitingFrames) {
            frameCounter = 0;
            obColor[Random.Range(0, 2)] = Random.Range(0.0f, 1.0f);
            render.material.color = new Color(obColor[0], obColor[1], obColor[2]);
        }
        frameCounter++;
    }
}
