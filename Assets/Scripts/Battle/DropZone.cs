using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler
{
    public EnemyAi enemyAi;
    public ManaBar manaBar;
    private CharacteristicsCounter characteristicsCounter;

    private void Awake()
    {
        characteristicsCounter = GetComponent<CharacteristicsCounter>();
        if (characteristicsCounter == null)
            Debug.Log("Error DropZone Script");
    }

    public void OnDrop(PointerEventData eventData)
    {
        DragAndDrop card = eventData.pointerDrag.GetComponent<DragAndDrop>();

        if(card)
        {
            GameObject ThisCard = eventData.pointerDrag;
            int dataMana = ThisCard.GetComponentInChildren<CardInfo>().CardMana;

            if (manaBar.TrySpendMana(dataMana))
                manaBar.SpendMana(dataMana);
            else
            {
                card.OnEndDrag(eventData);
                return;
            }

            characteristicsCounter.AddCharacteristics(ThisCard.GetComponentInChildren<CardInfo>().CardDamage, ThisCard.GetComponentInChildren<CardInfo>().CardArmor);
            card.defaultParent = transform;
            enemyAi.EnemyTurn();
        }
    }
}
