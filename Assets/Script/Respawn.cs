using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour
{

    public GameObject playerPref;

    public Transform pointOfCreation;


    void Start()
    {

        if(FindObjectOfType(playerPref.GetComponent<PlayerHere>().GetType()) == null)
        {

            Instantiate(playerPref, pointOfCreation.position, Quaternion.identity);




        }





    }
    

   


}
