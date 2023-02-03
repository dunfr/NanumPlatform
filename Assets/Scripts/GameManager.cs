using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public bool isRight;
    public bool isLeft;
    public bool isRotate;
    public bool circleRotate;
    public float musicTime;
    // Start is called before the first frame update
    void Awake()
    {
        Application.targetFrameRate = 60;    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
