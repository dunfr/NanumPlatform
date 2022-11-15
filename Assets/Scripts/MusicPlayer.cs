using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicPlayer : MonoBehaviour
{
    private int musicAtual = 0;
    private AudioSource audioSource;
    public AudioClip[] clipNames;
    public Slider musicLength;
    private bool stop = false;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        Singleton.Instance.musicTime = audioSource.clip.length;
        StopAudio();
    }
    // Update is called once per frame
    void Update()
    {
        if (!stop)
        {
            musicLength.value = audioSource.time;
            Singleton.Instance.musicTime -= Time.deltaTime;
        }
        Debug.Log(Singleton.Instance.musicTime);
    }
    public void StartAudio()
    {
        if (stop)
        {
            stop = false;
        }
        else if (!stop)
        {
            Singleton.Instance.musicTime = audioSource.clip.length;
        }
        musicLength.maxValue = audioSource.clip.length;
        musicLength.value = 0;
        audioSource.Play();        
    }
    public void StopAudio()
    {
        audioSource.Pause();
        stop = true;
    }
    public void go()
    {
        if (!stop)
        {
            audioSource.time += 2f;
            Singleton.Instance.musicTime -= 2f;
        }
    }
    public void back()
    {
        if (!stop)
        {
            audioSource.time -= 2f;
            Singleton.Instance.musicTime += 2f;
            if (audioSource.time<112.216f)
            {
                audioSource.Play();
                Singleton.Instance.musicTime = audioSource.clip.length;
            }
        }
    }
}
