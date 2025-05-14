using System.Runtime.CompilerServices;
using Obvious.Soap;
using UnityEngine;

[RequireComponent(typeof(AudioClip))]
public class Trimmer : MonoBehaviour, IBeautyTool
{
    [SerializeField] private LegStageType requiredStage = LegStageType.Hairy;
    [SerializeField] private LegCareManager legCareManager;
    [SerializeField] private AudioClip trimmerSound;
    [SerializeField] private SoundEventChannelSO soundEventChannel;



    public void UseTool(GameObject target)
    {
        if (legCareManager.IsToolValidForStage(requiredStage))
        {
            Debug.Log("Trimmer is used on " + target.name);
            Debug.Log("Trimmer used correctly!");
            soundEventChannel.RaiseEvent(trimmerSound);
            legCareManager.AdvanceStage();
        }
        else
        {
            Debug.Log("Wrong stage for Trimmer!");
        }
    }
}
