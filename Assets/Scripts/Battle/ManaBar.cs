using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManaBar : MonoBehaviour
{
    private GameObject manaCrystal;
    [SerializeField]
    private int maxManaCrystal;
    [SerializeField]
    private int currentManaCrystal;

    public EndTurn endTurn;

    private void Awake()
    {
        currentManaCrystal = maxManaCrystal;
        manaCrystal = Resources.Load("ManaCrystal") as GameObject;
        for (int i = 1; i <= maxManaCrystal; i++)
        {
            Instantiate(manaCrystal, transform);
            manaCrystal.GetComponentInChildren<Image>().color = Color.blue;
        }
    }

    public bool TrySpendMana(int manacost)
    {
        //Debug.Log(manacost);
        if (currentManaCrystal >= manacost)
            return true;
        else
        {
            Debug.Log("Не вистачає мани");
            return false;            
        }
    }

    public void SpendMana(int manacost)
    {
        currentManaCrystal -= manacost;
        ReDrowCrystal(currentManaCrystal);
        if (currentManaCrystal == 0)
            endTurn.NoMoves();
    }

    private void ReDrowCrystal(int fullCrysral)
    {
        for (int i = 1; i <= maxManaCrystal; i++)
        {
            GetComponentsInChildren<Image>()[i].color = Color.gray;
        }    

        for (int i = 1; i <= fullCrysral; i++)
        {
            GetComponentsInChildren<Image>()[i].color = Color.blue;
        }
    }
}
