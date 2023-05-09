using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeTrap : MonoBehaviour
{
    [SerializeField]private ParticleSystem trap;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
            trap.Play();
    }
}
