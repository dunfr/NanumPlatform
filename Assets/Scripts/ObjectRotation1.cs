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
            StartCoroutine(IERotation());                        
         }
    }
    IEnumerator IERotation()
    {
        for (int i = 0; i < 60; i++)
        {
            transform.Rotate(0, 0, rotatePoint);
            i++;
            yield return new WaitForSeconds(0.015f);
        }
    }
}
