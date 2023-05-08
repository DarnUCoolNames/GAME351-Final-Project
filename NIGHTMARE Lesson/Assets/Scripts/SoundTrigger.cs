using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTrigger : MonoBehaviour
{
    public AudioSource playSound;

    void OnTriggerStay(Collider other)
    {
        playSound.Play();
    }
}
