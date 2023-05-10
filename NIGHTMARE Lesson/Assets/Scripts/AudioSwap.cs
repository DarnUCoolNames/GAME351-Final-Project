using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSwap : MonoBehaviour
{
    public AudioClip newTrack;

    private void OntriggerEnter(Collider other)
    {
        if(other.CompareTag("PLayer"))
        {
        AudioManager.instance.SwapTrack(newTrack);
        }
    }
    private void OntriggerExit(Collider other)
    {
        if(other.CompareTag("PLayer"))
        {
        AudioManager.instance.ReturnToDefault();
        }
    }
}
