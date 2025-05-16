using UnityEngine;

public class Wax : MonoBehaviour, IBeautyTool
{

    [SerializeField] private LegStageType requiredStage = LegStageType.Trimmed;
    [SerializeField] private LegCareManager legCareManager;
    [SerializeField] private AudioClip trimmerSound;
    [SerializeField] private SoundEventChannelSO soundEventChannel;

    public void UseTool(GameObject target)
    {
        if (legCareManager.IsToolValidForStage(requiredStage))
        {
            Debug.Log("Wax is used on " + target.name);
            Debug.Log("Wax used correctly!");
            soundEventChannel.RaiseEvent(trimmerSound);
            legCareManager.AdvanceStage();
        }
        else
        {
            Debug.Log("Wrong stage for Wax!");
        }
    }
}