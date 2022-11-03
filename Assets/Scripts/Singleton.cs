using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton : MonoBehaviour
{
    private static Singleton instance = null;
    public bool isRight;
    public bool isLeft;
    void Awake()
    {
        if (null == instance)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    public static Singleton Instance
    {
        get
        {
            if(null == instance)
            {
                return null;
            }
            return instance;
        }                                                                      
    }
    void Update()
    {
        
    }
}
