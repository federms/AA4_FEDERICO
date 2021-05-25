using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball1AudioController : MonoBehaviour
{

    AudioSource[] sources;
    public Rigidbody rb;
    // Ball velocity
    float speed = 0.0f;
    bool IsPlaying = false;


    // Start is called before the first frame update
    void Start()
    {
        sources = GetComponents<AudioSource>();
        rb = GetComponent<Rigidbody>();
        sources[1].pitch = 1.0f / rb.mass;
    }

    // Update is called once per frame
    void Update()
    {
        speed = rb.velocity.magnitude;

        if (speed > 0.1f &&! IsPlaying) {
            IsPlaying = true;
            sources[0].Play();
        } else if (speed < 0.1f) {
            IsPlaying = false;
            sources[0].Stop();
        }

        sources[0].pitch = speed / rb.mass;

    }

    // Método llamada por Unity cuando chocamos con algo
    void OnCollisionEnter(Collision collision)
    {
        print("collision");
        // Acceder a la segunda fuente
        sources[1].Play();
    }

}
