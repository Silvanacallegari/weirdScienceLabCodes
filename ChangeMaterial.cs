using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterial : MonoBehaviour
{

    public Material[] material;
    Renderer rend;
    public GameObject doppel;
    private Transform target;

    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];
        target = doppel.transform;
    }

    void Update()
    {
        if (Vector3.Distance(transform.position, target.position) <= 1f)
        {
            rend.sharedMaterial = material[1];
        }
        else
        {
            rend.sharedMaterial = material[0];
        }


    }
}