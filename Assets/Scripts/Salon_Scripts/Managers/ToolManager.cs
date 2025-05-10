using UnityEngine;

public class ToolManager : MonoBehaviour
{
    public Transform toolSpawnPoint;

    public void SpawnAndUseTool(ToolType type, GameObject target)
    {
        GameObject toolObj = BeautyToolFactory.CreateTool(type, toolSpawnPoint);
        IBeautyTool tool = toolObj.GetComponent<IBeautyTool>();
        tool?.UseTool(target);
    }
}
