using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public KeyCode Fire = KeyCode.Mouse0;
    public GameObject Ammo;
    public GameObject spawnPoint;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKey(Fire))
        {
            GameObject bullet = Instantiate(Ammo, transform.position + (Vector3.zero * 1), Quaternion.identity);
            bullet.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * 10000);
        }

    }
}
