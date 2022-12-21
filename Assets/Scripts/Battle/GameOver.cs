using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    [SerializeField] private GameObject endGameBar;

    public void EndBattle(string name)
    {
        if (name == "Enemy")
            endGameBar.SetActive(true);
        else
            return;
    }
}
