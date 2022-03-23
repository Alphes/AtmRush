using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;

public class ATM : MonoBehaviour
{
    public TextMeshProUGUI ATMText;
    public static int ATMCounter = 0;
    public Transform AllMonies;
    //CollisionScript cs;
    private void Start()
    {
        ATMText = GameObject.Find("ATMText").GetComponent<TextMeshProUGUI>();
        AllMonies = GameObject.Find("AllMonies").transform;
        //cs = GameObject.FindObjectOfType<CollisionScript>();
    }
    private void Update()
    {
        ATMText.text = "ATM: "+ ATMCounter.ToString();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Collected") || other.gameObject.CompareTag("Golden") || other.gameObject.CompareTag("Diamond"))
        {
            ATMCounter++;
            Destroy(other.gameObject);

           
        }
    }
}
