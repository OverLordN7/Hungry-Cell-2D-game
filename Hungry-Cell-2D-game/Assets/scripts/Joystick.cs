using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class Joystick : MonoBehaviour
{
     Image image;
     RectTransform rectTransform;
    
    
    Vector2 startPosition = Vector2.zero;
    Vector2 position = Vector2.zero;

    [SerializeField]  Sprite ActiveSprite;
    [SerializeField] private Sprite IdleSprite;
    

    [HideInInspector]
    public float speed = 0.0f;
    [HideInInspector]
    public Vector2 direction = Vector2.zero;
    
    
    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        image = GetComponent<Image>();
    }
    
    public void OnPointerDown(BaseEventData data)
    {
        PointerEventData pntr = (PointerEventData) data;
        startPosition = pntr.position;
        image.sprite = ActiveSprite;

    }

    private float maxAllowedSize = 50.0f;
    
    public void OnDrag(BaseEventData data)
    {
        PointerEventData pntr = (PointerEventData) data;
        position = pntr.position - startPosition;
        float size = position.magnitude;
        if (size > maxAllowedSize)
        {
            speed = 1.0f;
            position = position / size * maxAllowedSize;
        }
        else
        {
            speed = size / maxAllowedSize;
        }

        direction = position / size;
        rectTransform.localPosition = position;
        
    }

    public void OnPointerUp(BaseEventData data)
    {
        speed = 0.0f;
        direction = Vector2.zero;
        rectTransform.localPosition = Vector2.zero;
        image.sprite = IdleSprite;
    }
}
