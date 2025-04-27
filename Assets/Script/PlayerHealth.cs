using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerHealth : MonoBehaviour
{

    public int maximalHealth = 100;

    private int currentHealth;

    private Transform respawnPoint;

    public Image healthBar;

    

    


    void Start()
    {
        GameObject respawnObj = GameObject.Find("RespawnPoint");

        if (respawnObj != null)
        {
            respawnPoint = respawnObj.transform;
        }



        currentHealth = maximalHealth;

        healthBar.fillAmount = 1f;

    }


    public void TakeDamage(int amount)
    {

        currentHealth -= amount;

        currentHealth = Mathf.Clamp(currentHealth, 0, maximalHealth);

        healthBar.fillAmount = (float)currentHealth / maximalHealth;

        

        if (currentHealth <= 0)
        {

            Respawn();

        }


    }


    void Respawn()
    {

        if (respawnPoint != null)
        {
            transform.position = respawnPoint.position;
        }

        

        currentHealth = maximalHealth;

        healthBar.fillAmount = 1f;


    }




}
