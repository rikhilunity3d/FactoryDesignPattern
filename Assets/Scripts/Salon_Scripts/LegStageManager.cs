using System.Collections.Generic;
using UnityEngine;

public class LegCareManager : MonoBehaviour
{
    [SerializeField] private SpriteRenderer legRenderer;
    [SerializeField] private List<LegStage> allStages; // Assigned in Inspector

    private Queue<LegStage> stageQueue;
    private LegStage currentStage;

    private void Start()
    {
        InitializeStages();
    }

    private void InitializeStages()
    {
        stageQueue = new Queue<LegStage>(allStages);
        AdvanceStage(); // Load the first stage
    }

    public void AdvanceStage()
    {
        if (stageQueue.Count == 0)
        {
            Debug.Log("All stages completed!");
            return;
        }

        currentStage = stageQueue.Dequeue();
        ApplyStage(currentStage);
    }

    private void ApplyStage(LegStage stage)
    {
        legRenderer.sprite = stage.legSprite;
        // Play stage sound later if needed
    }

    public LegStageType GetCurrentStageType()
    {
        return currentStage.stageType;
    }

    public bool IsToolValidForStage(LegStageType toolStage)
    {
        return currentStage.stageType == toolStage;
    }
}
