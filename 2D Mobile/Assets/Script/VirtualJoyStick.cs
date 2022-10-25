using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class VirtualJoyStick : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    [SerializeField] RectTransform lever;

    private RectTransform rectTransform;

    [SerializeField, Range(10.0f, 150.0f)] float leverRange;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        //    선택 방향     =   레버의 위치       -          클릭 위치
        var inputDirection = eventData.position - rectTransform.anchoredPosition;
        lever.anchoredPosition = inputDirection;
    }

    public void OnDrag(PointerEventData eventData)
    {
        var inputDirection = eventData.position - rectTransform.anchoredPosition;

        //                     조건
        var clampDirection = inputDirection.magnitude < leverRange ?
            //조건이 참 일때 : 조건이 거짓일 때
            inputDirection : inputDirection.normalized * leverRange;

        lever.anchoredPosition = clampDirection;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        lever.anchoredPosition = Vector2.zero;
    }
}
