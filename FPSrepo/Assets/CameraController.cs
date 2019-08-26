using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    void Update()
    {
        if (Input.mousePresent == true)
        {
            //transform.Rotate(0,transform.position.y + Input.GetAxis("Mouse Y"),0);
        }
    }
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}