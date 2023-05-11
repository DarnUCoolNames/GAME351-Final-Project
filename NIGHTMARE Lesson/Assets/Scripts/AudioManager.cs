using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip defaultAmbience;
    private AudioSource track01, track02;
    private bool isPlayingtrack01;
    public float volume = 1.0f;

    public static AudioManager instance;

    private void Awake()
    {
        if(instance == null)
           instance = this;

    }

    private void Start()
    {
        track01 = gameObject.AddComponent<AudioSource>();
        track02 = gameObject.AddComponent<AudioSource>();
        isPlayingtrack01 = true;

        SwapTrack(defaultAmbience);
    }

    public void SwapTrack(AudioClip newClip)
    {
        if (isPlayingtrack01)
        {
            track02.clip = newClip;
            track02.Play();
            track01.Stop();
        }
        else
        {
            track01.clip = newClip;
            track01.Play();
            track02.Stop();
        }
        isPlayingtrack01 = !isPlayingtrack01;
    }

    public void ReturnToDefault()
    {
        SwapTrack(defaultAmbience);
    }

}

