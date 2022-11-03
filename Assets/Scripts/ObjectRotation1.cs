using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ObjectRotation1 : MonoBehaviour
{
    [SerializeField]
    private float rotatePoint;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(IeRotation());
        }
    }

    IEnumerator IeRotation()
    {
        for (int i = 0; i < 180; i++)
        {
            transform.Rotate(0, 0, rotatePoint);
            i++;
            yield return null;
        }
    }
}
