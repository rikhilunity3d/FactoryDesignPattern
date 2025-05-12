using UnityEngine;

public class WaxStrip : MonoBehaviour, IBeautyTool
{
    [SerializeField] private LegStageType requiredStage = LegStageType.WaxApplied;
    [SerializeField] private LegCareManager legCareManager;

    public void UseTool(GameObject target)
    {
        if (legCareManager.IsToolValidForStage(requiredStage))
        {
            Debug.Log("WaxStrip is used on " + target.name);
            Debug.Log("WaxStrip used correctly!");
            legCareManager.AdvanceStage();
        }
        else
        {
            Debug.Log("Wrong stage for WaxStrip!");
        }
    }
}
