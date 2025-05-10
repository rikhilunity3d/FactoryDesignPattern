using UnityEngine;

public class Trimmer : MonoBehaviour, IBeautyTool
{
    public void UseTool(GameObject target)
    {
        Debug.Log("Trimmer is used on " + target.name);
    }
}
