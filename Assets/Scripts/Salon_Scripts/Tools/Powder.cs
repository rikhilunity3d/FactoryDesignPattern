using UnityEngine;

public class Powder : MonoBehaviour, IBeautyTool
{[SerializeField] private LegStageType requiredStage = LegStageType.WaxStripped;
    [SerializeField] private LegCareManager legCareManager;

    public void UseTool(GameObject target)
    {
        if (legCareManager.IsToolValidForStage(requiredStage))
        {
            Debug.Log("Powder applied to " + target.name);
            legCareManager.AdvanceStage(); // Moves to PowderApplied
        }
        else
        {
            Debug.Log("Wrong stage for Powder!");
        }
    }
}