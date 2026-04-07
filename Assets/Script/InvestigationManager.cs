using UnityEngine;

public class InvestigationManager : MonoBehaviour
{
    public static InvestigationManager Instance;

    public int totalClues = 5;
    public int foundClues = 0;

    void Awake()
    {
        Instance = this;
    }

    public void AddClue()
    {
        foundClues++;
        Debug.Log("Progress: " + foundClues + "/" + totalClues);
    }

    public bool CanFinish()
    {
        return foundClues >= 3;
    }
}