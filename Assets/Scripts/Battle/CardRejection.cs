using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardRejection : MonoBehaviour
{
    [SerializeField] private List<CardInfo> cardRejection = new List<CardInfo>();
    [SerializeField] private GameObject bord;


    public void Test()
    {
        //Card cards = bord.GetComponentInChildren<Card>();
        //Transform[]  father = GetComponentsInChildren<Transform>();
        int childCards = bord.transform.childCount;
        for (int i = 0; i < childCards; i++)
        {
            cardRejection.Add(bord.GetComponentsInChildren<CardInfo>()[i]);
            //Debug.Log(bord.GetComponentsInChildren<CardInfo>()[i].CardName);
            //bord.GetComponentsInChildren<GameObject>()[i]
            //Destroy(bord.GetComponentsInChildren<GameObject>()[i-1]);
            //Debug.Log(bord.transform.GetChild(i));
            //Debug.Log(bord.transform.GetChild(1));
            Destroy(bord.transform.GetChild(0).gameObject);
        }



    }

    public void Test2()
    {
        Debug.Log(bord.transform.GetChild(1));
    }
}
