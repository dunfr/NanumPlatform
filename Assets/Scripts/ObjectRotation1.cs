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
        transform.rotation = Quaternion.Slerp(transform.rotation,currentAngle, Time.deltaTime * 7);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Singleton.Instance.isRight)
            {
                rotatePoint -= 90;
                currentAngle = Quaternion.Euler(0, 0, rotatePoint);
                Debug.Log(currentAngle.eulerAngles);
            }
            if (Singleton.Instance.isLeft)
            {
                rotatePoint += 90;
                currentAngle = Quaternion.Euler(0, 0, rotatePoint);
                Debug.Log(currentAngle.eulerAngles);
            }
        }
    }
}
