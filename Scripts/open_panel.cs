using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class open_panel : MonoBehaviour, IPointerClickHandler
{
    public GameObject panel;
    public void OnPointerClick(PointerEventData eventData)
    {
        panel.SetActive(true);
    }
}