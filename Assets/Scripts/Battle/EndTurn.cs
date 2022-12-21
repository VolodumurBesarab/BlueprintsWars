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
    [SerializeField] private Effects effect;


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
        //effect.ApplyEffect(Effects.effectType.burn, enemy);
    }
}
