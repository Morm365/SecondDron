using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class GunScript : MonoBehaviour
{

    public Transform player;

    public Transform bulletPlace;

    public GameObject bullet;

    private bool shootCharge = true;

    public AudioSource shotSound;

    void Update()
    {

        Aiming();

        if (shootCharge &&  PlayerOnTheWay())
        {

            StartCoroutine(BulletCount());

        }


    }


    void Aiming() 
    {


        //angle = Mathf.Clamp(angle, -90f, 90f);
      
        Vector2 direction = player.position - transform.position;

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0, 0, angle);


    }



    bool PlayerOnTheWay()
    {


        Vector2 direction = (player.position - bulletPlace.position).normalized;

        RaycastHit2D hit = Physics2D.Raycast(bulletPlace.position, direction, Mathf.Infinity);

        if (hit.collider != null && hit.collider.CompareTag("Player"))
        {

            return true;


        }


        return false;



    }
     

    IEnumerator BulletCount()
    {

        shootCharge = false;


        for (int i = 0; i < 3; i++)
        {

            Launch();

            yield return new WaitForSeconds(0.1f);

        }

        yield return new WaitForSeconds(3f);

        shootCharge = true; 

    }


    void Launch()
    {

        Vector2 targetDirection = (player.position - bulletPlace.position).normalized;

        GameObject ProjectileBody = Instantiate(bullet, bulletPlace.position, Quaternion.identity);

        ProjectileBody.GetComponent<Projectile>().Initialize(targetDirection);

        StartCoroutine(ChangePlace(targetDirection));

        if (shotSound != null)
        {
            shotSound.Play();
        }

    }


    IEnumerator ChangePlace(Vector2 recoilDirection)
    {

        Vector3 firstPosition = transform.position;

        transform.position -= (Vector3)(recoilDirection * 0.1f);

        yield return new WaitForSeconds(0.05f);

        transform.position = firstPosition;

    }






}
