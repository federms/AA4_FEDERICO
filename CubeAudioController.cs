using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeAudioController : MonoBehaviour
{

    AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
        Renderer rend = GetComponent<Renderer>();
        Bounds bounds = rend.bounds;
        source.pitch = 1.0f / bounds.size.x;
    }

    // Update is called once per frame
    void Update()
    {
 
    }

    // Método llamada por Unity cuando chocamos con algo
    void OnCollisionEnter(Collision collision)
    {
        print("collision");
        // Acceder a la segunda fuente
        source.Play();
    }
}
