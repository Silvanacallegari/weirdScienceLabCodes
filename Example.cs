using UnityEngine;
using System.Collections;


public class Example : MonoBehaviour
{
    // Adjust the speed for the application.
    public float speed = 1.0f;
    public GameObject dopple;
    // The target (cylinder) position.
    private Transform target;

    void Awake()
    {
        // Position the cube at the origin.
        transform.position = new Vector3(0.0f, 0.0f, 0.0f);

        // Grab values and place on the camera.
        target = dopple.transform;
        
    }

    void Update()
    {


        // Move our position a step closer to the target.
        float step = speed * Time.deltaTime; // calculate distance to move
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);

        //rotation
        transform.rotation = Quaternion.Euler(0, dopple.transform.eulerAngles.y, 0);
        
    }
}
