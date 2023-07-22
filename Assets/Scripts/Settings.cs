using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class Settings : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject GearIcon;
    public Animator animator;
    public void OnPointerEnter(PointerEventData eventData)
    {
        animator.Play("Rotate");
    }

    void IPointerExitHandler.OnPointerExit(PointerEventData eventData)
    {
        
        animator.Play("Back");
    }
}
