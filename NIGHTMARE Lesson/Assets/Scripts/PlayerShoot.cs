using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject prefab;
    public GameObject ShootPoint;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            GameObject bullet = Instantiate(prefab);
            bullet.transform.position = this.transform.position;
            bullet.transform.rotation = this.transform.rotation;
        }
    }
}
