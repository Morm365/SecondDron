using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHid : MonoBehaviour
{

    // public GameObject targButton; 

    [SerializeField]

    private GameObject targButton;



    void Start()
    {

        //targButton.SetActive(false);

        //Invoke("Activate", 0.1f);

        StartCoroutine(ActivateAfterDelay());




    }


    System.Collections.IEnumerator ActivateAfterDelay()
    {


        yield return new WaitForSeconds(3f);


        targButton.SetActive(true);


    }

    //void Update()
    //{

    //   // targButton.SetActive(true);


    //}


}
