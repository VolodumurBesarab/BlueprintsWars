using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragAndDrop : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private Canvas mainCanvas;
    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;
    //private Transform defoultTempCardParent;
    private GameObject TempCardGO;
    public Transform defaultParent;
    public GameObject thisCard;


    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        mainCanvas = GetComponentInParent<Canvas>();
        canvasGroup = GetComponent<CanvasGroup>();
        TempCardGO = GameObject.Find("TempCardGO");
        //thisCard = GetComponentInChildren<GameObject>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
            
            defaultParent = transform.parent; //defoultTempCardParent =

            TempCardGO.SetActive(true);
            TempCardGO.transform.SetParent(defaultParent);
            TempCardGO.transform.SetSiblingIndex(transform.GetSiblingIndex());

            transform.SetParent(defaultParent.parent);
            canvasGroup.blocksRaycasts = false;
        
    }

    public void OnDrag(PointerEventData eventData)
    {
        rectTransform.anchoredPosition += eventData.delta / mainCanvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        transform.SetParent(defaultParent);
        transform.SetSiblingIndex(TempCardGO.transform.GetSiblingIndex());
        canvasGroup.blocksRaycasts = true;
        TempCardGO.SetActive(false);
    }
}
