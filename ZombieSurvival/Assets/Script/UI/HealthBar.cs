using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    Vector2 hp;
    Vector2 fullHp;

    private void Awake() 
    {
        fullHp = gameObject.GetComponent<RectTransform>().sizeDelta;
    }

    void Update()
    {
        hp = fullHp;
        hp.x *= (GameManager.instance.currentHealth / GameManager.instance.maxHealth);
        gameObject.GetComponent<RectTransform>().sizeDelta = hp;
    }
}
