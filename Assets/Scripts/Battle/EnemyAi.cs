using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAi : MonoBehaviour
{
    public Transform enemyBord;

    public void EnemyTurn()
    {
        if(transform.childCount > 0)
        {
            Transform card = GetComponentsInChildren<Transform>()[1];
            card.SetParent(enemyBord);
            //card.transform.SetParent(enemyBord.transform);
        }
    }
}
