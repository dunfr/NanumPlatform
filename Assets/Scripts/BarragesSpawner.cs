using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;
using UnityEngine.Timeline;

public class BarragesSpawner : MonoBehaviour
{
    public BarragesUI[] buts;
    public GameObject[] notePrefabs;
    public int CurrentButPressed;
    public Transform noteParent;
    private Vector2 screenPosition;
    private Vector2 worldPostion;
    private TimelineManager timelineManager;
    private BarragesManager barragesManager;
    void Awake()
    {
        timelineManager = GameObject.FindGameObjectWithTag("NoteManager").GetComponent<TimelineManager>();
    }
    void Update()
    {
        screenPosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        worldPostion = Camera.main.ScreenToWorldPoint(screenPosition);
        if (Input.GetMouseButtonDown(0) && buts[CurrentButPressed].clicked)     
        {
            buts[CurrentButPressed].clicked = false;
            timelineManager.note = Instantiate(notePrefabs[CurrentButPressed], new Vector3(worldPostion.x, worldPostion.y, 0), Quaternion.identity);
            timelineManager.Create(Singleton.Instance.musicTime);
            timelineManager.note.transform.parent = noteParent;
        }
    }
}
