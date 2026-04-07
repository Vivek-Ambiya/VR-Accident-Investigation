using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine;

public class DecisionSystem : MonoBehaviour
{
    public void SelectAnswer(string answer)
    {
        if (!InvestigationManager.Instance.CanFinish())
        {
            Debug.Log("Find more clues first!");
            return;
        }

        if (answer == "Oil Spill")
        {
            Debug.Log("Correct Answer!");
        }
        else
        {
            Debug.Log("Wrong Answer! Try Again.");
        }
    }
}
