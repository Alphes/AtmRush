using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class CollisionScript : MonoBehaviour
{
    private GameObject Player;

    public GameObject Money;

    private void Start()
    {
        Player = GameObject.Find("Player");
     
    }

    public IEnumerator MakeObjectBigger()
    {
        for (int i = List.instance.collactable.Count - 1; i >= 0; i--)
        {
            int index = i;
            Vector3 scale = new Vector3(5f, 5f, 5f);
            scale *= 1.5f;
            List.instance.collactable[index].transform.DOScale(scale, 0.1f).OnComplete(() => List.instance.collactable[index].transform.DOScale(new Vector3(5f, 5f, 5f), 0.1f));

            yield return new WaitForSeconds(0.05f);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && List.instance.collactable.Count == 0)
        {
            Vector3 newPos;
            newPos = Player.transform.position + new Vector3(0, 0, 1f);
            transform.position = newPos;
            gameObject.GetComponent<BoxCollider>().isTrigger = false;
            gameObject.transform.parent = Player.transform;
            
            gameObject.tag = "Money";
            List.instance.collactable.Add(gameObject);
            other.gameObject.tag = "Man";
        }

        else if (other.gameObject.CompareTag("Money") && List.instance.collactable.Count > 0)
        {
            if (gameObject.GetComponent<BoxCollider>().isTrigger == true)
            {
               // Debug.Log("Nigggaaaaa")
                Vector3 newPos;
                newPos = List.instance.collactable[List.instance.collactable.Count - 1].transform.position;
                newPos += Vector3.forward;
                transform.position = newPos;
                gameObject.GetComponent<BoxCollider>().isTrigger = false;
                gameObject.transform.parent = Player.transform;
                gameObject.tag = "Money";     
                List.instance.collactable.Add(gameObject);
                StartCoroutine(MakeObjectBigger());
            }   
        }


    }
}
