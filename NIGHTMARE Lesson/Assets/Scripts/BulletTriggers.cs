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

            GameObject progressBar = GameObject.Find("progressSlider"); 
            ProgressBar progressBarScript = progressBar.GetComponent<ProgressBar>();
            progressBarScript.EnemyDestroyed();

            GameObject puppetkid = Instantiate(prefab);
            puppetkid.transform.position = other.gameObject.transform.position;
            puppetkid.transform.rotation = other.gameObject.transform.rotation;

        }
    }

}
