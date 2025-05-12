using UnityEngine;

public class Soap : MonoBehaviour, IBeautyTool
{[SerializeField] private LegStageType requiredStage = LegStageType.Powdered;
    [SerializeField] private LegCareManager legCareManager;

    public void UseTool(GameObject target)
    {
        if (legCareManager.IsToolValidForStage(requiredStage))
        {
            Debug.Log("Soap applied to " + target.name);
            legCareManager.AdvanceStage(); // Moves to SoapApplied
        }
        else
        {
            Debug.Log("Wrong stage for Soap!");
        }
    }
}