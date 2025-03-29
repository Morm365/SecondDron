using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyUpper : MonoBehaviour
{

    public EnergyBar energyBar;

    public float upSpeed = 12f;

    public float artrificalGravity = -5f;

    public Rigidbody2D  robot;


    void Start()
    {



        if (energyBar == null)
        {


            GameObject energyObject = GameObject.FindGameObjectWithTag("Energy");

            if (energyObject != null)
            {

                energyBar = energyObject.GetComponent<EnergyBar>();


            }

            else
            {
                Debug.LogError("NO ENERGY BAR");
            }


        }






        robot = GetComponent<Rigidbody2D>();

        Physics2D.IgnoreLayerCollision(LayerMask.NameToLayer("Player"), LayerMask.NameToLayer("Ground"));
        Physics2D.IgnoreLayerCollision(LayerMask.NameToLayer("Player"), LayerMask.NameToLayer("Wall"));

    }


    void Update()
    {

        float horizontPower = robot.velocity.x;


        if (Input.GetKey(KeyCode.Space) && energyBar.energyPoints > 0)
        {

            robot.velocity = new Vector2(horizontPower, upSpeed);

          



            //transform.Translate(Vector2.up * upSpeed * Time.deltaTime);

        }


        else
        {
            robot.velocity = new Vector2(horizontPower, artrificalGravity);


        }

    }

}
