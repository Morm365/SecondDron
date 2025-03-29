using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenuStart : MonoBehaviour
{


    public string firstSceneName = "Scene1";



    public void StartGameFromMenu() 
    {

        PlayerPrefs.DeleteAll();

        SceneManager.LoadScene(firstSceneName);

    }



}
