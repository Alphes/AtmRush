using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class List : MonoBehaviour
{
    GameObject Player;
    public static List instance;
    public float movementDelay, originDelay;

    public List<GameObject> collactable = new List<GameObject>();

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    
    void Start()
    {
        Player = GameObject.Find("Player");
    }

    void Update()
    {
        if (Input.GetButton("Horizontal"))
        {
            MoveListElements();
        }
       if (Input.GetButtonUp("Horizontal"))
        {
           MoveOrigin();
        }
    }

    private void MoveListElements()
    {

        for (int i = 0; i < List.instance.collactable.Count; i++)
        {
            Vector3 pos = List.instance.collactable[i].transform.localPosition;
            if (i == 0)
            {
                pos.x = Player.transform.localPosition.x;
            }
            else
            {
                pos.x = List.instance.collactable[i - 1].transform.localPosition.x;

            }
            List.instance.collactable[i].transform.DOLocalMove(pos, movementDelay);    
        }


    }
    private void MoveOrigin()
    {
       
        for (int i = 0; i < List.instance.collactable.Count; i++)
            {
            Vector3 pos = List.instance.collactable[i].transform.localPosition;
            if (i == 0)
            {
                pos.x = Player.transform.localPosition.x;
            }
            else
            {
                pos.x = Player.transform.localPosition.x;
            }
           
            List.instance.collactable[i].transform.DOLocalMove(pos, originDelay);

            }
        

    }

}
