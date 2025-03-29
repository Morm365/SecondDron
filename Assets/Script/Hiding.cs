using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hiding : MonoBehaviour
{

    

    public float distanceVision = 4f;

    private SpriteRenderer spriteRenderer;

    private Transform player;

    void Start()
    {

        spriteRenderer = GetComponent<SpriteRenderer>();

        spriteRenderer.enabled = false;



    }



    void Update()
    {

        Debug.Log("CURRENT OBJ is " + gameObject.name);

        if (player == null)
        {

            GameObject founded = GameObject.FindGameObjectWithTag("Player");

            if (founded != null)
            {

                player = founded.transform;

                Debug.Log("HERE  PLAYER " + player.name);
            }
            else
            {
                Debug.Log("HERE  NO PLAYER");
                return;
            }

        }



        float distance = Vector2.Distance(transform.position, player.position);

        //spriteRenderer.enabled = distanñe <= distanceVision;  //visible unvisible in distance

        //gameObject.SetActive(distance <= distanceVision);

        spriteRenderer.enabled = distance <= distanceVision;

    }


}
