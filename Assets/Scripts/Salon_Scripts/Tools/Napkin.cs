using UnityEngine;

public class Napkin : MonoBehaviour, IBeautyTool
{[SerializeField] private LegStageType requiredStage = LegStageType.Washed;
    [SerializeField] private LegCareManager legCareManager;

    public void UseTool(GameObject target)
    {
        if (legCareManager.IsToolValidForStage(requiredStage))
        {
            Debug.Log("Napkin applied to " + target.name);
            legCareManager.AdvanceStage(); // Moves to NapkinApplied
        }
        else
        {
            Debug.Log("Wrong stage for Napkin!");
        }
    }
}