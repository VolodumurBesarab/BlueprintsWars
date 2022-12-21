using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardRejection : MonoBehaviour
{
    [SerializeField] private GameObject bord;
    [SerializeField] private CreateCardInfo createCardInfo;

    public void AddCardToRejection()
    {
        int count = bord.transform.childCount;
        for (int i = 1; i <= count; i++)
        {
            GameObject card = bord.transform.GetChild(0).gameObject;
            card.transform.SetParent(transform);
            card.transform.position = transform.position;
            createCardInfo.CardbackChange(card, true);
        }
    }
}
