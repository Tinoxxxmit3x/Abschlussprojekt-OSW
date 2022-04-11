using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerDamage : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public Image healthBar;

    private void Start()
    {
        currentHealth = maxHealth;
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            TakeDamage(10);


        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.fillAmount(currentHealth);


    }





}