using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public float maxHealth = 100f;
    public float currentHealth;


    private void Awake() 
    {
        instance = this;
        currentHealth = maxHealth;
    }
}
