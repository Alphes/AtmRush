using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag =="Money" || other.gameObject.tag == "Gold" || other.gameObject.tag == "Diamond"  )
        {

        }
    }





    /*
    public List<Transform> droppedItems;
    float colSize;

    void Start()
    {
        droppedItems = new List<Transform>();

        colSize = GameObject.Find("Player").GetComponent<BoxCollider>().size.z;
    }

   
    void Update()
    {
        colSize = GameObject.Find("Player").GetComponent<BoxCollider>().size.z;
    }

    public void DroppedItems()
    {
        for (int i = 0; i < droppedItems.Count; i++)
        {
            Vector3 randomPosition = new Vector3(Random.Range(-3f, 3f), List.instance.transform.position.y, Random.Range(List.instance.transform.position.z + 1, List.instance.transform.position.z + 3));
            droppedItems[i].transform.gameObject.SetActive(true);
            droppedItems[i].transform.localPosition = randomPosition;
        }

    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {


            for (int i = 0; i < List.instance.collactable.Count; i++)
            {

                List.instance.collactable[i].GetComponent<BoxCollider>().  = true;

            }
        }

        else if (other.tag == "Money")
        {
          
            }
        }

    }
    */


}

