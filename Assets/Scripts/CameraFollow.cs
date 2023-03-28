using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; 
    public float distance = 6.0f;
    public float height = 3.0f; 
    public float damping = 5.0f; 

    void FixedUpdate()
    {
        Vector3 desiredPosition = target.position - target.forward * distance + Vector3.up * height;

        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, Time.deltaTime * damping);

        transform.position = smoothedPosition;

        transform.LookAt(target);
    }
}
