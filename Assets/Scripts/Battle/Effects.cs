using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Effects : MonoBehaviour 
{ 

    public enum effectType {burn, frize};



    public void ApplyEffect(effectType effectType, Character character)
    {
        if (effectType == effectType.burn)
        {
            Burn(character);
        }
    }

    private void Burn(Character character)
    {
        character.TakeDamage(2);
    }
}

