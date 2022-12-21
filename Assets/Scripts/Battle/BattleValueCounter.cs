using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleValueCounter : MonoBehaviour
{
    [SerializeField] private CharacteristicsCounter playerCharacteristicsCounter;
    [SerializeField] private CharacteristicsCounter enemyCharacteristicsCounter;

    [SerializeField] private Player player;
    [SerializeField] private Enemy enemy;

    [SerializeField] private int totalPlayerDamage;
    [SerializeField] private int totalPlayerArmor;
    [SerializeField] private int totalEnemyDamage;
    [SerializeField] private int totalEnemyArmor;

    public void CountCharacteristic()
    {
        totalPlayerDamage = playerCharacteristicsCounter.currentDamage - enemyCharacteristicsCounter.currentDefense;
        //Debug.Log(totalPlayerDamage + " PlayerDmg");
        totalPlayerArmor = playerCharacteristicsCounter.currentDefense - enemyCharacteristicsCounter.currentDamage;
        //Debug.Log(totalPlayerArmor + " PlayerArmor");

        totalEnemyDamage = enemyCharacteristicsCounter.currentDamage - playerCharacteristicsCounter.currentDefense;
        if (totalEnemyDamage < 0)
            totalEnemyDamage = 0;
        //Debug.Log(enemyCharacteristicsCounter.currentDamage + " - " + playerCharacteristicsCounter.currentDefense + " = " + totalEnemyDamage);
        totalEnemyArmor = enemyCharacteristicsCounter.currentDefense - playerCharacteristicsCounter.currentDamage;
        if (totalEnemyArmor < 0)
            totalEnemyArmor = 0;
        Debug.Log(totalEnemyArmor + " enArmor");

        player.TakeDamage(totalEnemyDamage);
        player.GiveArmor(totalPlayerArmor);

        enemy.TakeDamage(totalPlayerDamage);
        enemy.GiveArmor(totalEnemyArmor);

        player.ShowCharacteristics();
        enemy.ShowCharacteristics();
    }

    public void CheckEffects()
    {
        GameObject bord = playerCharacteristicsCounter.GetComponentInParent<GameObject>();
        //bord.GetComponentsInChildren<>
    }
}
