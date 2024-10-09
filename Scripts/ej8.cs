using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej8 : MonoBehaviour
{
    private GameObject[] g2_spheres;

    // Start is called before the first frame update
    void Start()
    {
        g2_spheres = GameObject.FindGameObjectsWithTag("esfera_tipo_2");

        Transform trCubo = GetComponent<Transform>();
        GameObject closest = null, 
                   farthest = null;
        float min_distance = float.PositiveInfinity;
        float max_distance = float.NegativeInfinity;
        float current_distance = 0.0f;

        foreach (GameObject sphere in g2_spheres) {
            current_distance = Vector3.Distance(trCubo.position, sphere.transform.position);
            if (min_distance > current_distance) {
                min_distance = current_distance;
                closest = sphere;
            } else if (max_distance < current_distance) {
                max_distance = current_distance;
                farthest = sphere;
            }
        }
        closest.transform.position = new Vector3(closest.transform.position.x, closest.transform.position.y + 5, closest.transform.position.z);
        Renderer render = farthest.GetComponent<Renderer>();
        render.material.color = Random.ColorHSV();
    }
}