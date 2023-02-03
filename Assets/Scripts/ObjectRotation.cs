using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ObjectRotation : MonoBehaviour
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
        if (GameManager.Instance.isRight && GameManager.Instance.isRotate )
        {
            rotatePoint -= 90;
            currentAngle = Quaternion.Euler(0, 0, rotatePoint);
            GameManager.Instance.circleRotate = true;

            GameManager.Instance.isRotate = false;
            Debug.Log(currentAngle.eulerAngles);
        }
        if (GameManager.Instance.isLeft && GameManager.Instance.isRotate )
        {
            rotatePoint += 90;
            currentAngle = Quaternion.Euler(0, 0, rotatePoint);
            GameManager.Instance.isRotate = false;
            GameManager.Instance.circleRotate = true;
            Debug.Log(currentAngle.eulerAngles);
        }
    }

}
