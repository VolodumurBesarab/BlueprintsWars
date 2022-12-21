using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndTurn : MonoBehaviour
{
    private Button endTurn;
    [SerializeField] private ColorBlock colors;

    [SerializeField] private Enemy enemy;
    [SerializeField] private BattleValueCounter battleValueCounter;
    [SerializeField] private CharacteristicsCounter playerCharacteristicsCounter;
    [SerializeField] private DrawCards drowCards;
    [SerializeField] private ManaBar manaBar;

    //[SerializeField] private Effects effect;
    [SerializeField] private CardRejection cardRejection;


    private void Awake()
    {
        endTurn = GetComponent<Button>();
        if (endTurn == null)
            Debug.Log("Button is null");

        colors = endTurn.colors;
    }

    public void NoMoves()
    {
        colors.normalColor = Color.green;
        colors.selectedColor = Color.green;
        endTurn.colors = colors;
    }

    public void CanMove()
    {
        colors.normalColor = Color.yellow;
        colors.selectedColor = Color.yellow;
        endTurn.colors = colors;
    }

    public void PressEndTurnButton()
    {
        battleValueCounter.CountCharacteristic();
        cardRejection.AddCardToRejection();
        playerCharacteristicsCounter.NewRoundCharacteristics();
        drowCards.DrowCard();
        manaBar.RefreshMana();
        CanMove();
        //effect.ApplyEffect(Effects.effectType.burn, enemy);
    }
}
