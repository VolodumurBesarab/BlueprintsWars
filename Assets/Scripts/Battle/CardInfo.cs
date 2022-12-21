using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo : MonoBehaviour
{
    public string CardName { get; set; }
    public int CardId { get; set; }
    public int CardDamage { get; set; }
    public int CardArmor { get; set; }
    public Color Color { get; set; }
    public int CardMana { get; set; }
    public bool iSHide { get; set; }
    //public enum effects { set; get; }
}
