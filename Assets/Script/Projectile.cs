using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{


    public float speed = 10f;

    public int damage = 5;

    private Vector2 direction;


    public void Initialize(Vector2 directionP)
    {

        direction = directionP;

        
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0, 0, angle);

        Destroy(gameObject, 5f);

    }




 

    void Update()
    {

        transform.Translate(direction * speed * Time.deltaTime, Space.World);





    }


    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {

            other.GetComponent<PlayerHealth>().TakeDamage(damage);

            Destroy(gameObject);


        }



    }





}
