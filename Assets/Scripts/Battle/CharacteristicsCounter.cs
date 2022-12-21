using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacteristicsCounter : MonoBehaviour
{
    [SerializeField] private Text damage;
    [SerializeField] private Text defense;
    //private int damageNumber;
    //private int defenseNumber;
    [SerializeField] public int currentDamage;// { set; get; }
    [SerializeField] public int currentDefense;// { set; get; }

    private void Awake()
    {
        currentDamage = 0;
        currentDefense = 0;
    }

    public void AddCharacteristics(int damage, int defense)
    {
        currentDamage += damage;
        currentDefense += defense;
        ShowCharacteristics();
    }

    private void ShowCharacteristics()
    {
        damage.text = currentDamage.ToString();
        defense.text = currentDefense.ToString();
    }

    
}
