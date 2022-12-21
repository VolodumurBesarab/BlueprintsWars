using UnityEditor;
using UnityEngine;

public class Card
{
    public string CardName { get; set; }
    public int CardId { get; set; }
    public int CardDamage { get; set; }
    public int CardArmor { get; set; }
    public Color color { get; set; }
    public int cardMana{ get; set; }
    public bool iSHide { get; set; }
}