using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrool : MonoBehaviour
{


    public float speed = 5f;

    public float distance = 3f;

    public Transform model;

    private Vector3 startPosition;

    private bool moweRight = true;


    private bool stop = false;

    private Animator anim;


    void Start()
    {

        startPosition = transform.position;

        anim = model.GetComponent<Animator>();


    }

    

    void Update()
    {


        if(stop)
        {

            anim.Play("SpiderAn");

            return;

        }



        float direction = moweRight ? 1f : -1f;

        transform.Translate(Vector2.right * direction * speed * Time.deltaTime);

        if (moweRight && transform.position.x >= startPosition.x + distance)
        {

            FlipBack();

        }
        else if(!moweRight && transform.position.x <= startPosition.x - distance)
        {

            FlipBack();

        }


        anim.Play("SpiderDefaultAn");


        
    }

    void FlipBack()
    {
        moweRight = !moweRight;

        Vector3 scale = model.localScale;

        scale.x *= -1f;

        model.localScale = scale;


    }



    private void OnTriggerEnter2D(Collider2D other)
    {

        if(other.CompareTag("Player"))
        {

            stop = true;

        }

    }



    private void OnTriggerExit2D(Collider2D other) 
    {

        if (other.CompareTag("Player"))
        {

            stop = false;

        }

    }








}
