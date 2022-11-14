using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarragesUI : MonoBehaviour
{
    public int id;
    public bool clicked = false;
    private BarragesSpawner editer;
    // Start is called before the first frame update
    void Start()
    {
        clicked=false;
        editer = GameObject.FindGameObjectWithTag("EditorOnly").GetComponent<BarragesSpawner>();
    }
    public void ButtonClicked()
    {
        clicked = true;
        editer.CurrentButPressed = id;
    }
}
