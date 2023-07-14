using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MouseClick : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    [SerializeField] private AudioClip compressed,uncompressed;
    [SerializeField] private AudioSource source;
    public void OnPointerDown(PointerEventData eventData)
    {
        source.PlayOneShot(compressed);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        source.PlayOneShot(uncompressed);
    }
}

