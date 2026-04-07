using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvestigationPoint : MonoBehaviour
{
    public bool isFound = false;

    public void Investigate()
    {
        if (isFound) return;

        isFound = true;

        Debug.Log("Clue Found: " + gameObject.name);

        InvestigationManager.Instance.AddClue();

        // Optional: Change color
        GetComponent<Renderer>().material.color = Color.green;
    }
}
