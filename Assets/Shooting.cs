using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public KeyCode Fire = KeyCode.Mouse0;
    public GameObject Ammo;
    public float projectileSpeed = 2000;


    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKey(Fire))
        {
            var bullet = Instantiate(Ammo, transform.position, transform.rotation);
            bullet.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * projectileSpeed);
        }
    }
}
