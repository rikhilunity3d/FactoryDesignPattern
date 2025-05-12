using UnityEngine;

public class Shower : MonoBehaviour, IBeautyTool
{[SerializeField] private LegStageType requiredStage = LegStageType.Soaped;
    [SerializeField] private LegCareManager legCareManager;

    public void UseTool(GameObject target)
    {
        if (legCareManager.IsToolValidForStage(requiredStage))
        {
            Debug.Log("Shower applied to " + target.name);
            legCareManager.AdvanceStage(); // Moves to ShowerApplied
        }
        else
        {
            Debug.Log("Wrong stage for Shower!");
        }
    }
}