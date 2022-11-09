using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarragesSpawner : MonoBehaviour
{
    public GameObject box;
    public GameObject laser;
    public GameObject circle;
    // Start is called before the first frame update
    public void SpwanBox()
    {
        Instantiate(box, transform.position, transform.rotation);
    }
    public void SpwanCircle()
    {
        Instantiate(circle, transform.position, transform.rotation);
    }
    public void SpwanLaser()
    {
        Instantiate(laser, transform.position, transform.rotation);
    }
}
