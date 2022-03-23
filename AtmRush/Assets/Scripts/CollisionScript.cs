using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;

public class CollisionScript : MonoBehaviour
{
    public TextMeshProUGUI numberOfCollectableText;
    public Transform AllMoney;
    public static int numberOfCollectable = 0;
    public bool AtmControlFlag = false;



    private void Start()
    {

        AllMoney = GameObject.Find("AllMonies").transform;
        numberOfCollectableText = GameObject.Find("NumberOfCollectableText").GetComponent<TextMeshProUGUI>();

    }
    private void Update()
    {
        numberOfCollectableText.text = numberOfCollectable.ToString();
    }

    public IEnumerator MakeObjectBigger()
     {
         for (int i = AllMoney.childCount- 1; i >= 0; i--)
         {   
             int index = i;
             Vector3 scale = new Vector3(5f, 5f, 5f);
             scale *= 1.5f;
             AllMoney.GetChild(index).transform.DOScale(scale, 0.1f).OnComplete(() => AllMoney.GetChild(index).transform.DOScale(new Vector3(5f, 5f, 5f), 0.1f));
             yield return new WaitForSeconds(0.05f);
         }
     }


    private void OnTriggerEnter(Collider other)
    {
        AtmControlFlag = true;
        if (other.gameObject.CompareTag("Collect"))
        {
            numberOfCollectable++;
            other.gameObject.transform.position = transform.position + Vector3.forward;
            other.gameObject.AddComponent<CollisionScript>();
            other.gameObject.GetComponent<Collider>().isTrigger = false;
            other.gameObject.AddComponent<NodeMovement>();
            if (AllMoney.childCount == 0)
            {
                other.gameObject.GetComponent<NodeMovement>().connectedNode = transform;

            }
            else
            {
                other.gameObject.GetComponent<NodeMovement>().connectedNode = AllMoney.GetChild(AllMoney.childCount - 1).transform;
            }
          
            other.gameObject.GetComponent<NodeMovement>().nodeSpeed = 20;
            other.transform.parent = AllMoney.transform;


            other.gameObject.tag = "Collected";
            StartCoroutine(MakeObjectBigger());
        }
    }
}
