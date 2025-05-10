using UnityEngine;
using UnityEngine.EventSystems;

public class DropTarget : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        DraggableTool dragged = eventData.pointerDrag?.GetComponent<DraggableTool>();
        if (dragged != null)
        {
            IBeautyTool tool = dragged.GetComponent<IBeautyTool>();
            if (tool != null)
            {
                tool.UseTool(gameObject); // "gameObject" is the leg or target
                Debug.Log($"Used tool: {dragged.toolType} on {gameObject.name}");
            }
        }
    }
}
