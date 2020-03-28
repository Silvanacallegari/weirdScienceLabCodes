using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioOnCollision : MonoBehaviour
{
    public AudioSource tickSource;


    // Use this for initialization
    void Start()
    {
        tickSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision col)
    {
        //if (col.gameObject.tag == "Sphere")
            tickSource.Play();
    }
}