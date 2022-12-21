using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardsRepository : MonoBehaviour
{
    [SerializeField]
    public List<Card> cards = new List<Card>();

    
    private void Ponos()
    {

        cards.Add(new Card() { CardName = "TestCard0", CardId = 0, CardArmor = 1, CardDamage = 2, color = Color.black, cardMana = 1, iSHide = false});
        cards.Add(new Card() { CardName = "TestCard1", CardId = 1, CardArmor = 1, CardDamage = 2, color = Color.blue, cardMana = 2, iSHide = false });
        cards.Add(new Card() { CardName = "TestCard2", CardId = 2, CardArmor = 1, CardDamage = 2, color = Color.yellow, cardMana = 1, iSHide = false });
        cards.Add(new Card() { CardName = "TestCard3", CardId = 3, CardArmor = 1, CardDamage = 2, color = Color.green, cardMana = 2, iSHide = false });
    }
    
    private void Awake()
    {
        Ponos();
    }


    public Card SendInfo(int id)
    {
        //Виправити череду завантажень
        Ponos();
        Card result = cards.Find(x => x.CardId == id);
        return result;
    }

    public void Effects()
    {
        
    }

}
