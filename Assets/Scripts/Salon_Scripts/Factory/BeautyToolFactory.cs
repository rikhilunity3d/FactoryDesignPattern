using UnityEngine;

public static class BeautyToolFactory
{
    public static GameObject CreateTool(ToolType type, Transform parent)
    {
        string prefabName = type.ToString(); // "Trimmer", "Wax", etc.
        GameObject prefab = Resources.Load<GameObject>($"Salon_Tools/{prefabName}");
        
        if (prefab == null)
        {
            Debug.LogError($"Prefab for {type} not found.");
            return null;
        }

        return GameObject.Instantiate(prefab, parent);
    }
}
