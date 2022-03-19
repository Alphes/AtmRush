using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float movementSpeed;
    public float swipeSpeed;
    [SerializeField] float horSpeed;
    float horizontal;
    private Camera cam;

    void Start()
    {
        cam = Camera.main;
    }

    void FixedUpdate()
    {
        horizontal = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(horizontal * horSpeed * Time.deltaTime, 0, movementSpeed * Time.deltaTime));
    }

    
}
