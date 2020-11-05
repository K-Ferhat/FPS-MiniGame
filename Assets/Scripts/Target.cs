﻿using UnityEngine;

public class Target : MonoBehaviour
{
    public int health = 50;

    public void TakeDamage (int amount){
        health -= amount;
        Debug.Log(health);
        if (health <= 0){
            Die();
        }
    }

    void Die (){
        Destroy(gameObject);
    }
}
