using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAround : MonoBehaviour
{


    public GameObject dopple;
    Vector3 p2d, prod, dir;
    Rigidbody rb;

    Vector3 centre;

    float speed;
    float initialDistance;
    // Use this for initialization
    void Start()
    {
        // the number control how far away from the camera the dopple walks when meets camera
        centre = (dopple.transform.position - gameObject.transform.position) / 2;

        initialDistance = Vector3.Distance(gameObject.transform.position, dopple.transform.position);
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        //activate this function once the doppelganger enters the play area

        rb.AddForce(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        p2d = dopple.transform.position - gameObject.transform.position;    //player to doppel - v3 direction
        prod = Vector3.Cross(p2d, rb.velocity); //cross product to find if player is running away/towards doppelganger

        speed = p2d.magnitude / initialDistance;    //variable to control doppelganger's speed as it moves towards/away from the player

        dir = Vector3.Cross(-gameObject.transform.position, rb.velocity);   //clockwise or anti clockwise


        if (dir.y >= 0)
        {

            if (prod.y < 0)
            {
                //Debug.Log ("CL T " + prod.y + " , " + dir.y);
                dopple.transform.RotateAround(centre, Vector3.up, Time.deltaTime * 45 * speed);
            }
            else
            {
                //Debug.Log ("ACL A " + prod.y + " , " + dir.y);
                dopple.transform.RotateAround(centre, Vector3.down, Time.deltaTime * 45 * speed);
            }

        }
        else
        {

            if (prod.y < 0)
            {
                //Debug.Log ("ACL T " + prod.y + " , " + dir.y);
                dopple.transform.RotateAround(centre, Vector3.up, Time.deltaTime * 45 * speed);
            }
            else
            {
                //Debug.Log ("CL A " + prod.y + " , " + dir.y);
                dopple.transform.RotateAround(centre, Vector3.down, Time.deltaTime * 45 * speed);
            }

        }


    }
}