using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Warp4 : MonoBehaviour
{

    public string newScene = "Scene2";

    public string secondPoint = "SpawnPoint_B"; //target place

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {

            PlayerPrefs.SetString("SpawnPoint", secondPoint);

            SceneManager.LoadScene(newScene);

        }

    }
     


     
}