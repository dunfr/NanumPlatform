using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public Camera camera;
    Vector3 cameraPos;
    [SerializeField][Range(0.01f, 0.1f)] float shakeRange = 0.05f;
    [SerializeField][Range(0.1f, 1f)] float duration = 0.5f;
    public void shake()
    {
        cameraPos = camera.transform.position;
        InvokeRepeating("StartShake", 0f, 0.005f);
        Invoke("StopShake", duration);
    }
    void StartShake()
    {
        float cameraPosX = Random.value * shakeRange * 2 - shakeRange;
        float cameraPosY = Random.value * shakeRange * 2 - shakeRange;
        Vector3 cameraPos = camera.transform.position;
        cameraPos.x += cameraPosX;
        cameraPos.y += cameraPosY;
        camera.transform.position = cameraPos;
    }
    void StopShake()
    {
        CancelInvoke("startShake");
        camera.transform.position = cameraPos;

    }
}
