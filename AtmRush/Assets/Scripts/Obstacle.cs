using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Collected") || other.gameObject.CompareTag("Golden") || other.gameObject.CompareTag("Diamond"))
        {
            
        }
    }
}

