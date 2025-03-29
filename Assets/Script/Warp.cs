using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Warp : MonoBehaviour
{

    public string newScene = "Scene2";  

    public string spawnPoint = "SpawnPoint"; //target place

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {

            PlayerPrefs.SetString("SpawnPoint", spawnPoint);

            PlayerPrefs.SetString("PlaySound", "Yes");

            SceneManager.LoadScene(newScene);

        }

    }




}
