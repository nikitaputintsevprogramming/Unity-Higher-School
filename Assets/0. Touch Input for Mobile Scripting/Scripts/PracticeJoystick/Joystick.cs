using UnityEngine;
using UnityEngine.EventSystems;


public class Joystick : MonoBehaviour, IDragHandler, IEndDragHandler
{

    [SerializeField] GameObject Handle;

    [SerializeField] float MoveRadius;

    static Joystick instance;
    //—сылка на джойстик

    public static Vector2 Position
    {
        get 
        {
            return (instance.Handle.transform.position - instance.gameObject.transform.position).normalized;
        }
    }

    private void Start()
    {
        instance = this;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector3 inputPosition = eventData.position;
        
        Vector3 offset = inputPosition - gameObject.transform.position;

        offset = new Vector3(offset.x, offset.y, 0);
        Handle.gameObject.transform.position = gameObject.transform.position + Vector3.ClampMagnitude(offset, MoveRadius);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Handle.gameObject.transform.localPosition = Vector3.zero;
    }
}