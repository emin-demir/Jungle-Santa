using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SlotHover : MonoBehaviour, IPointerEnterHandler,IPointerExitHandler
{
    Color32 DefaultRenk = new Color32(48,67,67,255);
    Color32 HoverRenk = new Color32(80,97,97,255);


    public void OnPointerEnter(PointerEventData eventData)
    {
        GetComponent<Image>().color = HoverRenk;
    }

    void IPointerExitHandler.OnPointerExit(PointerEventData eventData)
    {
        GetComponent<Image>().color = DefaultRenk;

    }
}
