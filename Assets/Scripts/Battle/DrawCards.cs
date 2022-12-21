using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrawCards : MonoBehaviour
{
    [SerializeField] 
    private int startHandSize;
    [SerializeField]
    private CreateCardInfo createCardInfo;
    [SerializeField]
    private GameObject deck;


    public void Awake()
    {
        createCardInfo = GetComponent<CreateCardInfo>();
        //DrowSrartHand();
    }

    public void DrowSrartHand()
    {
        /*
        for (int i = 1; i<=startHandSize; i++)
        {
            GameObject card = Instantiate(Resources.Load("Card", typeof(GameObject)), transform) as GameObject;
            createCardInfo.CreateCard(card, false);
        }
        */
        for (int i = 1; i <= startHandSize; i++)
        {
            GameObject card = deck.GetComponentsInChildren<GameObject>()[1];
            Debug.Log(card.name);
            if (card != null)
                card.transform.SetParent(transform);

        }
    }

    public void DrowCard()
    {

    }
}
