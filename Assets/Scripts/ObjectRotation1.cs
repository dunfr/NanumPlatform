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
        transform.rotation = Quaternion.Slerp(transform.rotation, currentAngle, Time.deltaTime * 7);
        if (Singleton.Instance.isRight && Singleton.Instance.isRightRotate)
        {
            rotatePoint -= 90;
            currentAngle = Quaternion.Euler(0, 0, rotatePoint);
            Singleton.Instance.isRightRotate = false;
            Singleton.Instance.CircleRotate = true;
            Debug.Log(currentAngle.eulerAngles);
        }
        if (Singleton.Instance.isLeft && Singleton.Instance.isLeftRotate)
        {
            rotatePoint += 90;
            currentAngle = Quaternion.Euler(0, 0, rotatePoint);
            Singleton.Instance.isLeftRotate = false;
            Singleton.Instance.CircleRotate = true;
            Debug.Log(currentAngle.eulerAngles);
        }
    }

}
