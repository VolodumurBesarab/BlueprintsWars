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

    [SerializeField] private GameOver gameOver;

    private Text textHitPoints;
    private Text textArmor;

    private void Awake()
    {
        textHitPoints = GetComponentsInChildren<Text>()[1];
        textArmor = GetComponentsInChildren<Text>()[2];

        currentArmor = armor;
        currentHitPoints = hitPoints;

        ShowCharacteristics();
    }

    public void TakeDamage(int damage)
    {
        currentHitPoints -= damage;
        if (currentHitPoints <= 0)
            gameOver.EndBattle(name);
    }

    public void GiveArmor(int armor)
    {
        currentArmor += armor;
    }

    public void ShowCharacteristics()
    {
        textHitPoints.text = currentHitPoints.ToString();
        textArmor.text = currentArmor.ToString();
    }
}