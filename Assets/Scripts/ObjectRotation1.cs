using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ObjectRotation1 : MonoBehaviour
{
    private float rotatePoint;
    private Quaternion currentAngle;
    void Start()
    {
        currentAngle = transform.rotation;
        rotatePoint = 0;
    }
    void Update()
    {
         transform.rotation = Quaternion.Slerp(transform.rotation, currentAngle, Time.deltaTime * 5);
        if (Singleton.Instance.isRight && Singleton.Instance.isRotate )
        {
            rotatePoint -= 90;
            currentAngle = Quaternion.Euler(0, 0, rotatePoint);
            Singleton.Instance.circleRotate = true;
            
            Singleton.Instance.isRotate = false;
            Debug.Log(currentAngle.eulerAngles);
        }
        if (Singleton.Instance.isLeft && Singleton.Instance.isRotate )
        {
            rotatePoint += 90;
            currentAngle = Quaternion.Euler(0, 0, rotatePoint);
            Singleton.Instance.isRotate = false;
            Singleton.Instance.circleRotate = true;
            Debug.Log(currentAngle.eulerAngles);
        }
    }

}
