using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class DownButton : MonoBehaviour, IPointerDownHandler
{
    public UnityEvent onDownEvent;
    public void OnPointerDown(PointerEventData eventData)
    {
        onDownEvent.Invoke();
    }
}
