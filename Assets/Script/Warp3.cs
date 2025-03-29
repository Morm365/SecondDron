using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Warp3 : MonoBehaviour
{ 

    public string newScene = "Scene3";

    public string spawnPoint = "SpawnPoint_C "; //target place

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {

            PlayerPrefs.SetString("SpawnPoint", spawnPoint);

            SceneManager.LoadScene(newScene);

        }

    }




}
