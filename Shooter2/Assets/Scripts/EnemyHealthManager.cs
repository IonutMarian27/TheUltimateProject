using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class EnemyHealthManager : MonoBehaviour
{ 
    public  float startingHealth;
    public  float currentHealth;
    public Image HP;

    // Update is called once per frame
    void Start()
    {
            currentHealth = startingHealth;
    }
    
    // Update is called once per frame
    void Update()
    {
        HP.fillAmount = 1.0f * (currentHealth /startingHealth);
        if(currentHealth <= 0)
        {
            gameObject.SetActive(false); 
        }
    }

    public void DamageEnemy(int damage)
    {
        currentHealth -= damage;
    }
}