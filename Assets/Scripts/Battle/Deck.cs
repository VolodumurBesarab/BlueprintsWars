using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    [SerializeField]
    private int startDeckSize;
    [SerializeField]
    private CreateCardInfo createCardInfo;
    //private Transform parentTransform;

    private void Awake()
    {
        //parentTransform = GetComponent<Transform>();
        CreateDeck();
    }

    private void CreateDeck()
    {
        for (int i = 1; i <= startDeckSize; i++)
        {
            GameObject card = Instantiate(Resources.Load("Card", typeof(GameObject)), transform) as GameObject;
            card.GetComponent<CanvasGroup>().blocksRaycasts = false;
            createCardInfo.CreateCard(card, true);
        }
    }
}
