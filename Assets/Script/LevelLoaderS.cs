using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelLoaderS : MonoBehaviour
{


    public Animator transition;

    public float transitionTime = 5f;


    void Update()
    {


        
    }



    public void LoadNextLevel()
    {

       StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));

       

    }


    IEnumerator LoadLevel(int levelIndex)
    {

        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelIndex);


    }



}
