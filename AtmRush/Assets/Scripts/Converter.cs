using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Converter : MonoBehaviour
{
    
    CollisionScript collisionScript;
    void Start()
    {
        collisionScript = FindObjectOfType<CollisionScript>();
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Collected") )
        {
            other.gameObject.transform.GetChild(0).gameObject.SetActive(false);
            other.gameObject.transform.GetChild(1).gameObject.SetActive(true);
            other.gameObject.transform.GetChild(2).gameObject.SetActive(false);
            other.gameObject.tag = "Golden";
        }
        else if (other.gameObject.CompareTag("Golden"))
        {
            other.gameObject.transform.GetChild(0).gameObject.SetActive(false);
            other.gameObject.transform.GetChild(1).gameObject.SetActive(false); 
            other.gameObject.transform.GetChild(2).gameObject.SetActive(true);
            other.gameObject.tag = "Diamond";
        }
        StartCoroutine(collisionScript.MakeObjectBigger());
    }
}
