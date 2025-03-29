using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSound2 : MonoBehaviour
{
    public AudioSource spawAud;

    void Start()
    {
        if (PlayerPrefs.GetString("PlaySound") == "Yes")
        {

            spawAud.Play();

            PlayerPrefs.DeleteKey("PlaySound");

        }



    }


   

}
