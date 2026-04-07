using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI progressText;

    void Update()
    {
        progressText.text = InvestigationManager.Instance.foundClues + " / " + InvestigationManager.Instance.totalClues;
    }
}