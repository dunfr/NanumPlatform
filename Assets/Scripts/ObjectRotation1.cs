using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotation1 : MonoBehaviour
{
    [SerializeField]
    private Physics2D playerPhysics2D;
    // Update is called once per frame
    void Start()
    {
        playerPhysics2D = GetComponent<Physics2D>();    
    }
    void Update()
    {
         if (Input.GetKeyDown(KeyCode.Space))
         {
            StartCoroutine(IERotation());                        
         }

        gravity();
    }
    IEnumerator IERotation()
    {
        for (int i = 0; i < 60; i++)
        {
            transform.Rotate(0, 0, 3);
            i++;
            yield return new WaitForSeconds(0.015f);
        }
    }
    void gravity()
    {
        if (transform.rotation.z == 90)
        {
            
        }
    }
}
