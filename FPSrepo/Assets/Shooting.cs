using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public KeyCode Fire = KeyCode.Mouse0;
    public Rigidbody Ammo;
    public GameObject bulletSpawnPoint;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(Fire))
        {
            Instantiate(Ammo,(Vector3.up), Quaternion.LookRotation(Vector3.forward));
        }

    }
}
