using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrawCards : MonoBehaviour
{
    [SerializeField] private int startHandSize;
    [SerializeField] private int amountCardDrow;
    [SerializeField] private int handSize;

    [SerializeField] private CreateCardInfo createCardInfo;
    [SerializeField] private GameObject deck;


    public void Awake()
    {
        createCardInfo = GetComponent<CreateCardInfo>();
        //DrowStartHand();
    }

    
    public void DrowStartHand()
    {
        if (startHandSize <= handSize)
            for (int i = 1; i <= startHandSize; i++)
            {
                GameObject card = deck.transform.GetChild(i).gameObject;
                if (card != null)
                {
                    card.transform.SetParent(transform);
                    createCardInfo.CardbackChange(card, false);
                }
            }
        else
            Debug.Log("Досягнута максимальна кількість карт в руці");
        
    }
    

    public void DrowCard()
    {
        if (transform.childCount + amountCardDrow - 1 <= handSize)
            for (int i = 1; i <= amountCardDrow; i++)
            {
                GameObject card = deck.transform.GetChild(i).gameObject;
                if (card != null)
                {
                    card.transform.SetParent(transform);
                    createCardInfo.CardbackChange(card, false);
                }
            }
        else
            Debug.Log("У вас забагато карт");
        //return;
    }
}
