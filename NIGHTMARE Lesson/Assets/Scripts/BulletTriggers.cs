using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletTriggers : MonoBehaviour
{
    public GameObject prefab;
    public ParticleSystem explosion;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Evil_Kid"))
        {
            Destroy(other.gameObject);

            ParticleSystem PurityExplosion = Instantiate(explosion, other.transform.position, Quaternion.identity);
            PurityExplosion.Play();

            GameObject puppetkid = Instantiate(prefab);
            puppetkid.transform.position = other.gameObject.transform.position;
            puppetkid.transform.rotation = other.gameObject.transform.rotation;

        }
    }

}
