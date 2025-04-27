using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{

    public Transform player;

    private Vector3 scale;



    void Start()
    {

        scale = transform.localScale;


    }

   

    void Update()
    {


        if (player.position.x < transform.position.x)
        {

            transform.localScale = new Vector3(-Mathf.Abs(scale.x), scale.y, scale.z);

        }

        else
        {

            transform.localScale = new Vector3(Mathf.Abs(scale.x), scale.y, scale.z);

        }

    }


}
