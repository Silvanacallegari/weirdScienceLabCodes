using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class OnClickExample : MonoBehaviour
{
    // Start is called before the first frame update
   // void Start()
    //{
        
    //}

    // Update is called once per frame
    public void ChangeToScene(int sceneToChangeTo)
    {
        Application.LoadLevel(sceneToChangeTo);
    }
}
