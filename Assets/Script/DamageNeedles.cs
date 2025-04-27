using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageNeedles : MonoBehaviour
{

    public int damage = 50;

    void OnTriggerEnter2D(Collider2D other)
    {

       if (other.CompareTag("Player"))
        {

            PlayerHealth health = other.GetComponent<PlayerHealth>();


            if (health != null)
            {

                health.TakeDamage(damage);

            }

        }


    }

    




}

