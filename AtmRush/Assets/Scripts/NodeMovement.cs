using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeMovement : MonoBehaviour
{
    public Transform connectedNode;
    public float nodeSpeed;
    private void Update()
    {
        transform.position = new Vector3(Mathf.Lerp(transform.position.x, connectedNode.position.x, Time.deltaTime * nodeSpeed), connectedNode.position.y, connectedNode.position.z + 1);
    }
}
