using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class List : MonoBehaviour
{
    public static List instance;
    public GameObject Player;
    public List<GameObject> collactable = new List<GameObject>();
    public float movementDelay = 0.25f;


    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    void Update()
    {
        if (Input.GetButtonDown("Horizontal"))
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
        for (int i = 1; i < collactable.Count; i++)
        {

            Vector3 pos = collactable[i].transform.localPosition;
            pos.x = collactable[i - 1].transform.localPosition.x;

            collactable[i].transform.DOLocalMove(pos, movementDelay);


        }
    }

    private void MoveOrigin()
    {
        for (int i = 1; i < collactable.Count; i++)
        {
            //Debug.Log("MoveOrigin...");

            Vector3 pos = collactable[i].transform.localPosition;
            pos.x = collactable[0].transform.localPosition.x;
            collactable[i].transform.DOLocalMove(pos, 0.7f);
        }
    }
}
