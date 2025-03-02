using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDestination : MonoBehaviour
{

    public float speed = 1f;

    public float distance = 2f;

    private Vector3 Begin;

    private float direction = 2;


    void Start()
    {

        Begin = transform.position;


    }

    


    void Update()
    {

        transform.position += Vector3.right * direction *  speed * Time.deltaTime;

        if (Mathf.Abs(transform.position.x - Begin.x) >= distance)
        {
            direction *= -1;
        }

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))

        {

            collision.transform.SetParent(transform);


        }


    }


    private void OnCollisionExit2D(Collision2D collision)
    {


        if (collision.gameObject.CompareTag("Player"))
        {

            collision.transform.SetParent(null);


        }


    }


}
