using UnityEngine;

[CreateAssetMenu(menuName = "Leg Care/Leg Stage")]
public class LegStage : ScriptableObject
{
    public LegStageType stageType;
    public Sprite legSprite;
    public AudioClip stageSound;
    public float duration; // optional: time before moving to next stage
}
