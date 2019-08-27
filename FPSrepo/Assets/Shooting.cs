using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public KeyCode Fire = KeyCode.Mouse0;
    public GameObject Ammo;
    public float projectileSpeed = 200;


    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(Fire))
        {
            GameObject bullet = Instantiate(Ammo, transform.position, transform.rotation);
            bullet.GetComponent<Rigidbody>().AddRelativeForce(transform.forward * projectileSpeed);
        }
    }
}
