using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LegCareManager : MonoBehaviour
{
    [SerializeField] private Image legImage;
    [SerializeField] private List<LegStage> allStages;

    private Queue<LegStage> stageQueue;
    private LegStage currentStage;

    private void Start()
    {
        InitializeStages();
    }

    private void InitializeStages()
    {
        stageQueue = new Queue<LegStage>(allStages);
        AdvanceStage();
    }

    public void AdvanceStage()
    {
        if (stageQueue.Count == 0)
        {
            Debug.Log("All stages complete!");
            return;
        }

        currentStage = stageQueue.Dequeue();
        ApplyStage(currentStage);
    }

    private void ApplyStage(LegStage stage)
    {
        legImage.sprite = stage.legSprite;
    }

    public LegStageType GetCurrentStageType() => currentStage.stageType;

    public bool IsToolValidForStage(LegStageType toolStage)
    {
        return currentStage.stageType == toolStage;
    }
}
