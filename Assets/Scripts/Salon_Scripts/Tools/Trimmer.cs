using UnityEngine;

public class Trimmer : MonoBehaviour, IBeautyTool
{
    [SerializeField] private LegStageType requiredStage = LegStageType.Hairy;
    [SerializeField] private LegCareManager legCareManager;

    public void UseTool(GameObject target)
    {
        if (legCareManager.IsToolValidForStage(requiredStage))
        {
            Debug.Log("Trimmer is used on " + target.name);
            Debug.Log("Trimmer used correctly!");
            legCareManager.AdvanceStage();
        }
        else
        {
            Debug.Log("Wrong stage for Trimmer!");
        }
    }
}
