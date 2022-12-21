using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Character : MonoBehaviour
{
    [SerializeField] private int hitPoints; //Set in inspector
    [SerializeField] private int armor;     //Set in inspector
    [SerializeField] private int currentHitPoints;
    [SerializeField] private int currentArmor;

    private Text textHitPoints;
    private Text textArmor;
    //private int HitPoints;  // { get; set; }
    //private int Armor;      // { get; set; }

    private void Awake()
    {
        //HitPoints = hitPoints;
        //Armor = armor;

        textHitPoints = GetComponentsInChildren<Text>()[1];
        textArmor = GetComponentsInChildren<Text>()[2];

        currentArmor = armor;
        currentHitPoints = hitPoints;

        ShowCharacteristics();
    }

    public void TakeDamage(int damage)
    {
        currentHitPoints -= damage;
        //textHitPoints.text = currentHitPoints.ToString();
    }

    public void GiveArmor(int armor)
    {
        currentArmor += armor;
        //textHitPoints.text = currentArmor.ToString();
    }

    public void ShowCharacteristics()
    {
        textHitPoints.text = currentHitPoints.ToString();
        textArmor.text = currentArmor.ToString();
    }
        
}