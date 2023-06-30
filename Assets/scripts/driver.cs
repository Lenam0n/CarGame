using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class driver : MonoBehaviour
{
    [SerializeField]
    private float rotationSpeed = 80f;

    [SerializeField]
    private float movementSpeed = 4f;

    [SerializeField] 
    float slowSpeed = 2f;

    [SerializeField] 
    float boostSpeed = 10f;





    // Update is called once per frame
    void Update()
    {
        float inputHor = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
        float inputVer = Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime;
        //if (Input.GetAxis("") > 0f){}
        transform.Rotate(0, 0, -inputHor);
        transform.Translate(0f, inputVer, 0f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        movementSpeed = slowSpeed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "SpeedBuff")
        {

            movementSpeed = boostSpeed;
        }
    }
}

