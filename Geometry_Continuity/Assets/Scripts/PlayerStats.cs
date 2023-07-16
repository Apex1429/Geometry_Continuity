using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int maxHP = 1000;
    public int currentHP = 1000;


    public void TakeDamage(int damage)
    {
        currentHP -= damage;

        if(currentHP <= 0)
        {
            Debug.Log("You are dead! GAME OVER!");
        }
    }
}
