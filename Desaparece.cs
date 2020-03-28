using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desaparece : MonoBehaviour
{
    public GameObject Ghost;
    // Start is called before the first frame update
    void Start()
    {
      
        Ghost.SetActive(true);
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision col)
    {
        //if (col.gameObject.tag == "Player")
        //{
           Ghost.SetActive(false);


        //}

    }
}

