using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public Transform camTransform;
    public float SmoothTime = 0.3f;
    private Vector3 velocity = Vector3.zero;
    void Start()
    {
        offset = camTransform.position - target.position;
    }

    void LateUpdate()
    {
      //  Vector3 targetPosition = target.position + offset;
     //   camTransform.position = Vector3.Lerp(transform.position, targetPosition, ref velocity, SmoothTime);
        camTransform.position = Vector3.Lerp(camTransform.position, target.position + offset, Time.deltaTime);
        //transform.LookAt(target);
    }
}
