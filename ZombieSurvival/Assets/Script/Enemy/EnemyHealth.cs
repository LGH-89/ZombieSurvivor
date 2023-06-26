using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float enemyMaxHp = 100;
    [SerializeField] float enemyCurrentHp;
    public GameObject hpBar;
    Vector3 enemyFullHpBar;
    Vector3 enemyHpBar;

     private void Awake() 
    {
        enemyCurrentHp = enemyMaxHp;
        enemyFullHpBar = hpBar.transform.localScale;
    }

    void Update()
    {
        HpBar();
        EnemyDead();
    }

    void HpBar() 
    {
        enemyHpBar = enemyFullHpBar;
        float hpRate = enemyCurrentHp / enemyMaxHp;

        if (hpRate < 0) hpRate = 0;

        enemyHpBar.x *= hpRate;
        hpBar.transform.localScale = enemyHpBar;
    }

    void EnemyDead() 
    {
        if (enemyCurrentHp <= 0) {
            gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other) 
    {
        if (other.tag == "Damage") {
            Debug.Log("1");
            enemyCurrentHp -= 20;
        }
    }
}
