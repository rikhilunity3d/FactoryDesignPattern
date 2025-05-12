using UnityEngine;

public class Wax : MonoBehaviour, IBeautyTool
{

    [SerializeField] private LegStageType requiredStage = LegStageType.Trimmed;
    [SerializeField] private LegCareManager legCareManager;

    public void UseTool(GameObject target)
    {
        if (legCareManager.IsToolValidForStage(requiredStage))
        {
            Debug.Log("Wax is used on " + target.name);
            Debug.Log("Wax used correctly!");
            legCareManager.AdvanceStage();
        }
        else
        {
            Debug.Log("Wrong stage for Wax!");
        }
    }
}