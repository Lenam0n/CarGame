using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public GameObject car;
    // Update is called once per frame
    void LateUpdate()
    {

        transform.position = car.transform.position + new Vector3(0,0,-10f); 
    }
}
