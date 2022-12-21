using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateCardInfo : MonoBehaviour
{
    [SerializeField]
    private Card currentClassCard;
    public CardsRepository cardsRepository;
    public CardInfo cardInfo;
    


    public void CreateCard(GameObject card, bool isHide)
    {
        currentClassCard = cardsRepository.SendInfo(Random.Range(0, 4));
        card.GetComponentInChildren<Text>().text = currentClassCard.CardName;
        card.GetComponentInChildren<Image>().color = currentClassCard.color;
        card.GetComponentsInChildren<Text>()[1].text = "Damage: " + currentClassCard.CardDamage + " Armor: " + currentClassCard.CardArmor;
        card.GetComponentsInChildren<Text>()[2].text = currentClassCard.cardMana.ToString();
        var cardBack = card.GetComponentsInChildren<Image>()[3].color;
        if (isHide)
        {
            Debug.Log(card.GetComponentsInChildren<Image>()[3].name);
            cardBack.a = 255f;
        }
        else
            cardBack.a = 0f;
        card.GetComponentsInChildren<Image>()[3].color = cardBack;
        WriteCardInfo(card);
    }

    private void WriteCardInfo(GameObject card)
    {
        card.GetComponentInChildren<CardInfo>().CardName = currentClassCard.CardName;
        card.GetComponentInChildren<CardInfo>().CardId = currentClassCard.CardId;
        card.GetComponentInChildren<CardInfo>().CardDamage = currentClassCard.CardDamage;
        card.GetComponentInChildren<CardInfo>().CardArmor = currentClassCard.CardArmor;
        card.GetComponentInChildren<CardInfo>().Color = currentClassCard.color;
        card.GetComponentInChildren<CardInfo>().CardMana = currentClassCard.cardMana;
    }
}