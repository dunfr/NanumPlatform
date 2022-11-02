using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CmeraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public float smoothFactor=0.125f;
    void FixedUpdate()
    {
        follow();    
    }
    void follow()
    {
        Vector3 targetPostion = target.position + offset;
        Vector3 smoothPositon = Vector3.Lerp(transform.position, targetPostion, smoothFactor);
        transform.position = smoothPositon;
    }
}
