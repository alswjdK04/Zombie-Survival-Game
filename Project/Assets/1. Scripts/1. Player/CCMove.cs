using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CCMove : MonoBehaviour
{
    CharacterController CC;
    float speed = 5;
    Vector3 sumVec, xVec, yVec, zVec;
    float yAxis = 0;
    float r;
    float rotateSpeed = 100;
    float gravity = 3.8f;

    void Start()
    {
        CC = GetComponent<CharacterController>();
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal") * speed;
        float z = Input.GetAxis("Vertical") * speed;

        xVec = transform.right * x * Time.deltaTime;

        /*
        if (CC.isGrounded == true)
        {
            yAxis = 0f;
            if (Input.GetButton("Jump"))
                yAxis = 0f;
        }
        else
        {
            yAxis -= gravity * Time.deltaTime;
        }
        */
        if (CC.isGrounded == false)
        {
            yAxis -= gravity * Time.deltaTime;
        }

        yVec = new Vector3(0, yAxis, 0);
        zVec = transform.forward * z * Time.deltaTime;

        sumVec = xVec + yVec + zVec;

        CC.Move(sumVec);
        r = Input.GetAxis("Mouse X") * Time.deltaTime * rotateSpeed;
        transform.Rotate(0, r, 0);
    }
}
