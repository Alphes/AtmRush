using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ForTextPosition : MonoBehaviour
{
    public TextMeshProUGUI forText;

    void LateUpdate()
    {
        Vector3 forTextPosition = Camera.main.WorldToScreenPoint(this.transform.position);
        forText.transform.position = forTextPosition;
    }
}
