using UnityEngine;
using UnityEngine.EventSystems;

public class DraggableTool : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private CanvasGroup canvasGroup;
    private Vector3 originalPosition;
    private Transform originalParent;

    public ToolType toolType;

    void Awake()
    {
        canvasGroup = GetComponent<CanvasGroup>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        originalPosition = transform.position;
        originalParent = transform.parent;
        canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        transform.position = originalPosition;
        transform.SetParent(originalParent);
        canvasGroup.blocksRaycasts = true;
    }
}
