using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class BarragesSpawner : MonoBehaviour
{
    public BarragesUI[] buts;
    public GameObject[] NotePrefabs;
    public int CurrentButPressed;
    private Vector2 screenPosition;
    private Vector2 worldPostion;
    private IObjectPool<BarragesManager> _Pool;
    void Awake()
    {
        _Pool = new ObjectPool<BarragesManager>(CreateNote, OngetNote, OnReleaseNote, OnDestroyNote, maxSize: 20);
    }
    void Update()
    {
        screenPosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        worldPostion = Camera.main.ScreenToWorldPoint(screenPosition);
        if (Input.GetMouseButtonDown(0) && buts[CurrentButPressed].clicked)     
        {
            buts[CurrentButPressed].clicked = false;
            var note = _Pool.Get();
            //Instantiate(NotePrefabs[CurrentButPressed], new Vector3(worldPostion.x, worldPostion.y, 0), Quaternion.identity);
        }
    }
    private BarragesManager CreateNote()
    {
        BarragesManager Note = Instantiate(NotePrefabs[CurrentButPressed]).GetComponent<BarragesManager>();
        Note.SetManagedPool(_Pool);
        return Note;
    }
    private void OngetNote(BarragesManager barragesManager)
    {
        barragesManager.gameObject.SetActive(true);
    }
    private void OnReleaseNote(BarragesManager barragesManager)
    {
        barragesManager.gameObject.SetActive(false);
    }
    private void OnDestroyNote(BarragesManager barragesManager)
    {
        Destroy(barragesManager.gameObject);
    }
}
