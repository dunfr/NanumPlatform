using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotation1 : MonoBehaviour
{
    // Update is called once per frame
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
            transform.Rotate(0, 0, -3);
            i++;
            yield return new WaitForSeconds(0.01f);
        }
    }
}
