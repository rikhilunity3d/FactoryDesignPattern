using UnityEngine;

public class Wax : MonoBehaviour, IBeautyTool
{
    public void UseTool(GameObject target)
    {
        Debug.Log("Applying wax on " + target.name);
    }
}