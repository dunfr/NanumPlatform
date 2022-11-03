using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ObjectRotation1 : MonoBehaviour
{
    [SerializeField]
    private float rotatePoint;
    public Quaternion currentAngle;
    void Start()
    {
        currentAngle = transform.rotation;
    }
    void Update()
    {
        transform.rotation = Quaternion.Slerp(transform.rotation,currentAngle, Time.deltaTime * 4);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Singleton.Instance.isRight)
            {
                rotatePoint -= 90;
                currentAngle = Quaternion.Euler(0, 0, rotatePoint-5);
                Debug.Log(currentAngle.eulerAngles);
            }
            if (Singleton.Instance.isLeft)
            {
                rotatePoint += 90;
                currentAngle = Quaternion.Euler(0, 0, rotatePoint-5);
                Debug.Log(currentAngle.eulerAngles);
            }
        }
    }
    void turnRight()
    {

    }
    void turnLeft()
    {

    }

    IEnumerator IeRotation()
    {/*
        for (int i = 0; i < 180; i++)
        {
            transform.Rotate(0, 0, rotatePoint);
            i++;
            yield return null;
        }
        */
        while (true)
        {
            Quaternion firstRotation = transform.rotation;
            transform.rotation = Quaternion.Lerp(transform.rotation,firstRotation,Time.deltaTime);
            yield return null;
        }
    }
}
