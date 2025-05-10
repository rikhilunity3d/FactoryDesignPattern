using UnityEngine;

public class Powder : MonoBehaviour, IBeautyTool
{
    public void UseTool(GameObject target)
    {
        Debug.Log("Applying Powder on " + target.name);
    }
}