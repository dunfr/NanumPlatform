using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicPlayer : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip[] clipNames;
    public Slider musicLength;
    private bool stop = false;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        StopAudio();
    }
    // Update is called once per frame
    void Update()
    {
        if (!stop)
        {
            musicLength.value = audioSource.time;
            Singleton.Instance.musicTime = audioSource.time;
        }
        //Debug.Log(Singleton.Instance.musicTime);
    }
    public void StartAudio()
    {
        if (stop)
        {
            stop = false;
        }
        musicLength.maxValue = audioSource.clip.length;
        musicLength.value = 0;
        audioSource.Play();
        Time.timeScale = 1;
    }
    public void StopAudio()
    {
        audioSource.Pause();
        Time.timeScale = 0;
        stop = true;
    }
    public void go()
    {
        if (!stop)
        {
            audioSource.time += 2f;
        }
    }
    public void back()
    {
        if (!stop)
        {
            audioSource.time -= 2f;
            if (audioSource.time<112.216f)
            {
                audioSource.Play();
            }
        }
    }
}
