using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform target;

    public float smoothspeed;

    public Vector3 offset;

    // Update is called once per frame
    void LateUpdate()
    {
        
        Vector3 smoothedPosition = new Vector3(0, 0, target.position.z);
        transform.position = smoothedPosition + offset;
    }
}
