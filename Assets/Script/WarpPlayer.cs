using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarpPlayer : MonoBehaviour
{
    public string defaultSpawn = "DefaultSpawn";

    void Start()
    {

        string spawnPointName = PlayerPrefs.GetString("SpawnPoint", defaultSpawn);

        GameObject spawnPoint = GameObject.Find(spawnPointName); 

        if(spawnPoint != null)
        {

            transform.position = spawnPoint.transform.position;

        }


    }

    

}
