using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainController : MonoBehaviour
{
    public float RainRate = 1000f;
    private ParticleSystem rainParticleSystem;

    void Start()
    {
        rainParticleSystem = GetComponent<ParticleSystem>();
    }

    void Update()
    {
        var emissionModule = rainParticleSystem.emission;
        emissionModule.rateOverTime = RainRate;
    }
}
