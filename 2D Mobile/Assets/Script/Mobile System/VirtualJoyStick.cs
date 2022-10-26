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
        //    ���� ����     =   ������ ��ġ       -          Ŭ�� ��ġ
        var inputDirection = eventData.position - rectTransform.anchoredPosition;
        lever.anchoredPosition = inputDirection;
    }

    public void OnDrag(PointerEventData eventData)
    {
        var inputDirection = eventData.position - rectTransform.anchoredPosition;

        //                     ����
        var clampDirection = inputDirection.magnitude < leverRange ?
            //������ �� �϶� : ������ ������ ��
            inputDirection : inputDirection.normalized * leverRange;

        lever.anchoredPosition = clampDirection;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        lever.anchoredPosition = Vector2.zero;
    }
}
