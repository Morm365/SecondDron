using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSound : MonoBehaviour
{

    public AudioSource flightSound;



    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {

            flightSound.Play();

        }



    }



}
