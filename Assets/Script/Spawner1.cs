using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner1 : MonoBehaviour
{
   
    public GameObject objectSpawned;

    public float timeBetweenSoawning = 10f;


        


    void Start()
    {

        StartCoroutine(Spawn());

    }


    IEnumerator Spawn()
    {

        while (true)
        {

            SpawnPref();

            yield return new WaitForSeconds(timeBetweenSoawning);

        }

    }
    


    void SpawnPref()
    {

        Instantiate(objectSpawned, transform.position, Quaternion.identity);


    }


}
