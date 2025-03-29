using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFirstSpawn : MonoBehaviour
{

    public GameObject PlayerP;

    public Transform spawnPointStart; 

    void Start()
    {

        Vector3 spawnPosition;


       // PlayerPrefs.DeleteKey("SpawnPoint");


        if (PlayerPrefs.HasKey("SpawnPoint"))
        {

            string spawnPointName = PlayerPrefs.GetString("SpawnPoint");

            GameObject point = GameObject.Find(spawnPointName);

            //Instantiate(PlayerP, spawnPointStart.position, Quaternion.identity);


            if (point != null)
            {

                spawnPosition = point.transform.position;


            }
            else
            {

                spawnPosition = spawnPointStart.position;


            }

            PlayerPrefs.DeleteKey("SpawnPoint");




        }
        else
        {

            spawnPosition = spawnPointStart.position;


        }

        Instantiate(PlayerP, spawnPosition, Quaternion.identity);


    }

   

    

}
