using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float movementSpeed;
    public Transform Player;
    public float swipeSpeed;
    [SerializeField] float horSpeed;
    float horizontal;
    private Camera cam;
    public Transform allMonies;
    public float distance = 4f;

    void Start()
    {
        cam = Camera.main;
        Player = GameObject.Find("Player").transform;
    }

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(horizontal * horSpeed * Time.deltaTime, 0, movementSpeed * Time.deltaTime));

    }

}



