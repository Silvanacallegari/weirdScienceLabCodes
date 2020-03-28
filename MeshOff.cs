using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshOff : MonoBehaviour
{


    public GameObject ghost;

    void Start()
    {
        ghost.GetComponent<MeshRenderer>().enabled = true;

    }

    void OnCollisionEnter(Collision collision)
    {
        ghost.GetComponent<MeshRenderer>().enabled = false;

    }

}