using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class TimelineManager : MonoBehaviour
{
    public TimelineAsset timelineAsset;
    public GameObject note;
    private PlayableDirector playableDirector;
    // Start is called before the first frame update
    void Start()
    {
        playableDirector = GetComponent<PlayableDirector>();
    }
    // Update is called once per frame
    void Update()
    {
        //playableDirector.time = Singleton.Instance.musicTime;
        if (Input.GetKeyDown(KeyCode.A))
        {
            Create(Singleton.Instance.musicTime);
        }
        Debug.Log(playableDirector.time);
    }
    private void Create(float starttime)
    {
        var track = timelineAsset.CreateTrack<ActivationTrack>(null, "Activation Track");
        playableDirector.SetGenericBinding(track, note);
        var clip = track.CreateDefaultClip();
        clip.start = 5;
        clip.duration = 3f;
    }
}
