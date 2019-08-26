using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;
    public float maxLookUpAngle = 270;
    public float maxLookDownAngle = 90;

    
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    void Update()
    {
        if (Input.mousePresent)
        {
            transform.RotateAround(transform.position, transform.right, -Input.GetAxis("Mouse Y"));
        }
        if (transform.localRotation.eulerAngles.z > 0.15f || transform.localRotation.eulerAngles.z < -0.15f)
        {
            if (transform.localRotation.eulerAngles.x > maxLookUpAngle)
            {
                transform.eulerAngles = new Vector3(maxLookUpAngle, player.transform.eulerAngles.y - 90f, 0f);
            }

            if (transform.localRotation.eulerAngles.x < maxLookDownAngle)
            {
                transform.eulerAngles = new Vector3(maxLookDownAngle, player.transform.eulerAngles.y - 90f, 0f);
            }
        }
        else
        {
            transform.eulerAngles = new Vector3(transform.localRotation.eulerAngles.x, player.transform.eulerAngles.y - 90f, 0f);
        }
    }
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}