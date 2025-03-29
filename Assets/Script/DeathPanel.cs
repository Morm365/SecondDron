using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathPanel : MonoBehaviour
{


    public Transform teleTarget;

    public AudioSource teleSound;

    private void OnTriggerEnter2D(Collider2D other)
    {

         
        if (other.CompareTag("Player"))  
        {


            other.transform.position = teleTarget.position;

            if(teleSound != null)
            {

                teleSound.Play();

            }


        }

    }

}

