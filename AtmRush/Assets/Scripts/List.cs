using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class List : MonoBehaviour
{
    public static List instance;

    public List<GameObject> collactable = new List<GameObject>();

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

}
