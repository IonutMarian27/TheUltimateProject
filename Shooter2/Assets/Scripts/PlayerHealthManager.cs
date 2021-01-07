using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthManager : MonoBehaviour
{
    public float hp;
    public static float startingHealth;
    public static float currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        startingHealth = hp;
        currentHealth = hp;
    }

    // Update is called once per frame
    void Update()
    {
        if(currentHealth <= 0)
        {
            gameObject.SetActive(false); 
            hp = currentHealth;
        }

        hp = currentHealth;
    }
    
    public void DamagePlayer(int damage)
    {
        currentHealth -= damage;
    }
}
