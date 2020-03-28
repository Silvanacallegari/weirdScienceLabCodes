using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;

public class LookAt : MonoBehaviour
{
    public Transform target;

    void Update()
    {
        // Rotate the camera every frame so it keeps looking at the target
        //transform.LookAt(target);

        transform.LookAt(new Vector3(target.position.x, -90f, target.position.z));


    }
}

