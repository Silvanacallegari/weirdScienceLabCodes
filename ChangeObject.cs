using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeObject : MonoBehaviour
{
    public GameObject plant;
    public GameObject otherPlant;
    // Start is called before the first frame update
     
    // Update is called once per frame
    public void ChangeObjectTo(bool changeObjectToPlant)
    {
        otherPlant.SetActive(false);
        plant.SetActive(true);
    }
}
